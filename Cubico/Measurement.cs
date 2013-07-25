using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;

namespace Cubico
{
	// A structure that defines a measurement with a numeric value and a unit of measure.
	[Serializable]
	[DataContract]
	[KnownType(typeof(Unit))]
	[KnownType(typeof(UnitType))]
	[KnownType(typeof(Symbol))]
	[KnownType(typeof(Modifier))]
	[KnownType(typeof(ConversionResult))]
	public struct Measurement : IEquatable<Measurement>, IComparable<Measurement>
	{
		#region "Private Fields"
		MeasurementFlags _flags;
		UnitConverter _uc;
		double _maxbound;
		double _minbound;
		public double _standardValue;
		//Unit _standardUnit;
		double _value;
		Unit _unit;
		string _symbol;
		Result _conversionResult;

		public event EventHandler OnValueChanged;
		public event EventHandler OnUnitChanged;
		#endregion
		#region "Constructors"
		internal Measurement (string unitSymbol)
		{
			// Reference the unit converter that created us.
			_uc = new UnitConverter ();

			_flags = MeasurementFlags.None;
			_maxbound = 0;
			_minbound = 0;
			_standardValue = 0;
			// _standardUnit = null;
			_symbol = null;
			OnValueChanged = null;
			OnUnitChanged = null;

			if (string.IsNullOrWhiteSpace (unitSymbol)) {
				// System.Diagnostics.Debug.Print("First IF Statement")
				_unit = null;
				_conversionResult = Result.BadUnit;
			} else {
				// System.Diagnostics.Debug.Print("First ELSE Statement")
				_unit = _uc.GetUnitBySymbol (unitSymbol);
				_conversionResult = Result.NoError;

				if (_unit.Symbols.Contains (new Symbol { Value = unitSymbol })) {
					_symbol = unitSymbol;
				} else {
					_symbol = _unit.DefaultSymbol;
				}
			}

			_value = 0;
		}

		public Measurement (double value, string unitSymbol)
            : this(unitSymbol)
		{

			if (!string.IsNullOrWhiteSpace (unitSymbol)) {
				_unit = _uc.GetUnitBySymbol (unitSymbol);
			}

			_value = value;
		}

		internal Measurement (double value, string unitSymbol, Result conversionResult)
            : this(unitSymbol)
		{

			_value = value;

			_conversionResult = conversionResult;
		}

		internal Measurement (double value, Result conversionResult)
            : this(null)
		{

			_value = value;

			_conversionResult = conversionResult;
		}

		internal Measurement (double value, Unit unit, Result conversionResult = Result.NoError)
		{
			// Reference the unit converter that created us.
			_uc = new UnitConverter ();
			_flags = MeasurementFlags.None;
			_unit = unit;
			_conversionResult = Result.NoError;
			_value = value;
			_conversionResult = conversionResult;

			_maxbound = 0;
			_minbound = 0;
			_standardValue = 0;
			// _standardUnit = null;
			_symbol = null;
			OnValueChanged = null;
			OnUnitChanged = null;
		}
		#endregion
		#region "measurement flags and properties methods"
		// Gets a reference to the current unit of the measurement.
		public Unit Unit {
			get { return _unit; }
		}
		// Gets or sets the flags on this measurement.
		public MeasurementFlags Flags {
			get { return _flags; }
			set { _flags = value; }
		}
		// Gets the unit converter associated with this measurement.
		public UnitConverter Converter {
			get { return _uc; }
		}
		// Displays the result of a conversion.
		// This property will default to NoError unless there were problems after a conversion.
		public Result ConversionResult {
			get { return _conversionResult; }
			set { _conversionResult = value; }
		}

		public double Value {
			get { return _value; }
		}

		public string Symbol {
			get {
				if (_unit == null) {
					return null;
				} else {
					return _symbol;
				}
			}
		}
		// Gets the current value of the measurement in string form.
		public string FullValue {
			get {
				string str = _value.ToString ();

				if (_unit != null) {
					if (!string.IsNullOrEmpty (_unit.DefaultSymbol)) {
						str += _unit.DefaultSymbol;
					} else {
						str += _unit.Name;
					}
				}

				return str;
			}
		}

		public bool IsValid {
			get {
				if (_conversionResult != Result.NoError && _conversionResult != Result.UnitExists) {
					return false;
				} else if (_uc == null) {
					return false;
				} else if (_unit == null) {
					return false;
				} else {
					return true;
				}
			}
		}
		#endregion
		#region "Value getting and setting methods"
		// Sets the unit of the measurement.
		internal Result SetUnit (string unitSymbol)
		{
			Unit unit = _uc.GetUnitBySymbol (unitSymbol);

			if (unit == null) {
				return Result.BadUnit;
			} else {
				// If its the same don't touch it.
				if (unit.DefaultSymbol == _unit.DefaultSymbol) {
					return Result.NoError;
				}

				_unit = unit;

				if (OnUnitChanged != null) {
					OnUnitChanged (this, EventArgs.Empty);
				}

				return Result.NoError;
			}
		}
		// Given a string in the format "[value] [unit]" parses and applies the value and unit.
		internal Result SetValue (string measurement)
		{
			if (string.IsNullOrEmpty (measurement)) {
				throw new ArgumentNullException ("measurement");
			}
			Contract.EndContractBlock ();

			double d = 0;
			string symbol = null;
			Result res = default(Result);

			res = ValidateEntry (measurement);
			if (res != Result.NoError) {
				return res;
			}

			Measurement newRes = _uc.ParseUnitString (measurement);

			d = newRes.Value;
			symbol = newRes.Symbol;

			// Can we change the unit?
			if ((_flags & MeasurementFlags.ForceUnit) > 0) {
				// Can't change the unit, so turn the given units into the unit we want.
				Measurement convRes = _uc.ConvertUnits (d, symbol, _unit.Name);
				d = convRes.Value;
			} else {
				// Change the measurement unit to the given unit.
				SetUnit (symbol);
			}

			SetValue (d);
			return res;
		}
		// Sets a value in the currently set unit format.
		internal Result SetValue (double value)
		{
			Measurement res = default(Measurement);
			Unit standardUnit = default(Unit);
			UnitType tp = _unit.UnitType;
			standardUnit = (from un in tp.Units where un.IsDefault == true select un).FirstOrDefault ();
			res = _uc.ConvertUnits (value, _unit.Name, standardUnit.Name);

			_value = value;
			_standardValue = res.Value;

			if (res.ConversionResult != Result.NoError) {
				return res.ConversionResult;
			}

			if (OnValueChanged != null) {
				OnValueChanged (this, EventArgs.Empty);
			}

			return res.ConversionResult;
		}
		// Gets the value of the measurement in the specified units.
		public Measurement GetValueAs (string unitSymbol)
		{
			return _uc.ConvertUnits (_value, _unit.Name, unitSymbol);
		}

		public string GetStringValueAs (string unitSymbol)
		{
			Measurement res = default(Measurement);
			res = _uc.ConvertUnits (_value, _unit.Name, unitSymbol);

			if (res.ConversionResult != Result.NoError) {
				return "Conversion Error";
			} else {
				return res.FullValue;
			}
		}
		#endregion
		#region "Validation methods"
		// Validates input to the measurement.
		public Result ValidateEntry (string entry)
		{
			string unit = null;
			double d = 0;
			Measurement res = default(Measurement);

			// Parse the entry.
			res = _uc.ParseUnitString (entry);
			if (res.ConversionResult != Result.NoError) {
				return res.ConversionResult;
			}

			unit = res.Symbol;
			d = res.Value;

			return ValidateEntryUnitData (unit, d);
		}

		public Result ValidateEntry (double value, string symbol)
		{
			return ValidateEntryUnitData (symbol, value);
		}

		Result ValidateEntryUnitData (string unit, double x)
		{

			// Make sure the units are compatible.
			if (!_uc.IsCompatible (unit, this._unit.DefaultSymbol)) {
				return Result.UnitMismatch;
			}

			Measurement newRes = _uc.ConvertUnits (x, unit, this.Unit.Name);
			x = newRes.Value;

			if ((this._flags & MeasurementFlags.UseMaxBound) > 0) {
				if (x > this._maxbound) {
					return Result.ValueTooHigh;
				}
			}

			if ((this._flags & MeasurementFlags.UseMinBound) > 0) {
				if (x < this._minbound) {
					return Result.ValueTooLow;
				}
			}

			return Result.NoError;
		}
		#endregion
		#region "Bounds setting methods"
		// Sets the maximum bound of the measurement.
		public Result SetMaxBound (double maxbound, string unitSymbol)
		{
			if (string.IsNullOrEmpty (unitSymbol)) {
				throw new ArgumentNullException ("unitSymbol");
			}

			if (!_uc.IsCompatible (unitSymbol, this._unit.DefaultSymbol)) {
				return Result.UnitMismatch;
			}

			Measurement res = _uc.ConvertUnits (maxbound, unitSymbol, _unit.Name);

			this._maxbound = res.Value;

			return Result.NoError;
		}
		// Sets the minimum bound of the measurement.
		public Result SetMinBound (double minbound, string unitSymbol)
		{
			if (string.IsNullOrEmpty (unitSymbol)) {
				throw new ArgumentNullException ("unitSymbol");
			}

			if (!_uc.IsCompatible (unitSymbol, this._unit.DefaultSymbol)) {
				return Result.UnitMismatch;
			}

			Measurement res = _uc.ConvertUnits (minbound, unitSymbol, _unit.Name);

			this._minbound = res.Value;

			return Result.NoError;
		}
		#endregion
		#region "Operator overloads"
		// Gets a string representation of the measurement.
		public override string ToString ()
		{
			return this.FullValue;
		}
		// Adds two measurements together.
		public static Measurement operator + (Measurement d1, Measurement d2)
		{
			double x = 0;
			double y = 0;

			x = d1.Value;

			if (d2.Unit.ID == d1.Unit.ID) {
				y = d2.Value;
			} else {
				y = d2.Value;
				Measurement res2 = d2.Converter.ConvertUnits (y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
				y = res2.Value;
			}

			var result = new Measurement (x + y, d1.Unit);
			return result;
		}
		// Subtracts two measurements.
		public static Measurement operator - (Measurement d1, Measurement d2)
		{
			double x = 0;
			double y = 0;

			x = d1.Value;

			if (d2.Unit.ID == d1.Unit.ID) {
				y = d2.Value;
			} else {
				y = d2.Value;
				Measurement res2 = d2.Converter.ConvertUnits (y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
				y = res2.Value;
			}

			var result = new Measurement (x - y, d1.Unit);
			return result;
		}
		// Multiplies two measurements.
		public static Measurement operator * (Measurement d1, Measurement d2)
		{
			double x = 0;
			double y = 0;

			x = d1.Value;

			if (d2.Unit.ID == d1.Unit.ID) {
				y = d2.Value;
			} else {
				y = d2.Value;
				Measurement res2 = d2.Converter.ConvertUnits (y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
				y = res2.Value;
			}

			var result = new Measurement (x * y, d1.Unit);
			return result;
		}
		// Divides two measurements.
		public static Measurement operator / (Measurement d1, Measurement d2)
		{
			double x = 0;
			double y = 0;

			x = d1.Value;

			if (d2.Unit.ID == d1.Unit.ID) {
				y = d2.Value;
			} else {
				y = d2.Value;
				Measurement res2 = d2.Converter.ConvertUnits (y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
				y = res2.Value;
			}

			Measurement result = new Measurement (x / y, d1.Unit);
			return result;
		}

		public static bool operator != (Measurement left, Measurement right)
		{
			return !left.Equals (right);
		}

		public static bool operator == (Measurement left, Measurement right)
		{
			return left.Equals (right);
		}

		public static bool operator < (Measurement left, Measurement right)
		{
			return (left.CompareTo (right) < 0);
		}

		public static bool operator > (Measurement left, Measurement right)
		{
			return (left.CompareTo (right) > 0);
		}

		public static bool operator <= (Measurement left, Measurement right)
		{
			return (left.CompareTo (right) <= 0);
		}

		public static bool operator >= (Measurement left, Measurement right)
		{
			return (left.CompareTo (right) >= 0);
		}
		#endregion
		#region "IEquatable(Of Measurement)"
		public override int GetHashCode ()
		{
			Measurement MeRes = default(Measurement);
			string str = string.Empty;
			if (this.ConversionResult != Result.NoError) {
				str = this.Value.ToString () + "|" + this.ConversionResult.ToString ();
			} else {
				Unit standardUnit = default(Unit);
				UnitType tp = this.Unit.UnitType;
				standardUnit = (from un in tp.Units where un.IsDefault == true select un).FirstOrDefault ();

				MeRes = this.Converter.ConvertUnits (this._value, this.Unit.DefaultSymbol, standardUnit.DefaultSymbol);
				str = MeRes.Value.ToString () + "|" + MeRes.Symbol;
			}

			return str.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			if (obj == null || !object.ReferenceEquals (obj.GetType (), typeof(Measurement))) {
				return false;
			}

			Measurement Mobj = (Measurement)obj;
			return this.Equals (Mobj);
		}

		public bool Equals (Measurement other)
		{
			if (other.ConversionResult != Result.NoError) {
				return false;
			}

			if (this.ConversionResult != Result.NoError) {
				return false;
			}

			if (object.ReferenceEquals (this.Unit, null) && object.ReferenceEquals (other.Unit, null)) {
				return true;
			}

			if (object.ReferenceEquals (this.Unit, null) ^ object.ReferenceEquals (other.Unit, null)) {
				return false;
			}

			if (this.Unit.Name == other.Unit.Name && this.Value == other.Value) {
				return true;
			} else {
				Measurement OtherRes = other.Converter.ConvertUnits (other._value, other.Unit.Name, this.Unit.Name);

				if (OtherRes.ConversionResult != Result.NoError) {
					return false;
				} else if (this.Unit.Name != OtherRes.Unit.Name) {
					return false;
				} else if (this.Value != OtherRes.Value) {
					return false;
				} else {
					return true;
				}
			}
		}
		#endregion
		#region "ICompareTo(Of Measurement)"
		public int CompareTo (Measurement other)
		{
			if (other.ConversionResult != Result.NoError) {
				throw new ArgumentException ("other", "the 'other' parameter must have a valid value");
			}

			if (this.ConversionResult != Result.NoError) {
				throw new ArgumentException ("this", "object must have a valid value");
			}

			Unit standardUnit = default(Unit);
			UnitType tp = this.Unit.UnitType;
			standardUnit = (from un in tp.Units where un.IsDefault == true select un).FirstOrDefault ();

			Unit otherStandardUnit = default(Unit);
			tp = this.Unit.UnitType;
			otherStandardUnit = (from un in tp.Units where un.IsDefault == true select un).FirstOrDefault ();

			Measurement meRes = this.Converter.ConvertUnits (this._value, this.Unit.DefaultSymbol, standardUnit.DefaultSymbol);
			Measurement otherRes = other.Converter.ConvertUnits (other._value, other.Unit.DefaultSymbol, otherStandardUnit.DefaultSymbol);

			if (meRes.Symbol != otherRes.Symbol) {
				throw new ArgumentException ("The parameter must be of the same unit type as this object. " + this.Unit.DefaultSymbol, "other");
			}

			return meRes.Value.CompareTo (otherRes.Value);
		}
		#endregion
	}
}