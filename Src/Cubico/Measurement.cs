using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Cubico.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100a9a0195dc31c78d63e25c1b47a72bccca2d9f5be7c850437d6ecae03a9e2208dfb97c07969e6bdaf1530307c1c819c6948f99198622f966a08701eca0bfdebf745355dfadb9d37a89a230a3f604beb9b274338efd1fc822f72ca0787faa88efae7af7749a9e6e2f9870ffdd94895e0e352a9bffde2b917640042e4b05b527390")]

namespace Cubico
{
	/// <summary>
    /// A basic structure that defines a measurement with a numeric value and a unit of measure.
	/// </summary>
    /// <example>
    /// var length_in_ft = new Measurement(2, Units.Length.Feet);
    /// var length_in_in = new Measurement(12, Units.Length.Inches);
    /// var result = length_in_ft + length_in_in;
    /// Console.WriteLine(result.GetValueAs(Units.Length.Yards).ToString()); // = 1 yard
    /// </example>    
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
        internal double _standardValue;
		//Unit _standardUnit;
		double _value;
		Unit _unit;
		string _symbol;
		Result _conversionResult;

        //public event EventHandler OnValueChanged;
        //public event EventHandler OnUnitChanged;
		#endregion
		#region "Constructors"
		public Measurement (string unitSymbol)
		{
			// Reference the unit converter that created us.
			_uc = new UnitConverter ();
			_flags = MeasurementFlags.None;
			_maxbound = 0;
			_minbound = 0;
			_standardValue = 0;
			_symbol = null;

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

		public Measurement (double value, string unitSymbol, Result conversionResult)
            : this(unitSymbol)
		{
			_value = value;
			_conversionResult = conversionResult;
		}

		public Measurement (double value, Result conversionResult)
            : this(null)
		{
			_value = value;
			_conversionResult = conversionResult;
		}

		public Measurement (double value, Unit unit, Result conversionResult = Result.NoError)
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
            //OnValueChanged = null;
            //OnUnitChanged = null;
		}
		#endregion
		#region "measurement flags and properties methods"
		/// <summary>
        /// Gets a reference to the current unit of the measurement.
		/// </summary>
		public Unit Unit {
			get { return _unit; }
		}
		/// <summary>
        /// Gets or sets the flags on this measurement.
		/// </summary> 
		public MeasurementFlags Flags {
			get { return _flags; }
			set { _flags = value; }
		}
		// Gets the unit converter associated with this measurement.
		internal UnitConverter Converter {
			get { return _uc; }
		}

        	
        /// <summary>
        /// Displays the result of a conversion.
        /// </summary>
        /// <remarks>
        /// This property will default to NoError unless there were problems after a conversion.
        /// </remarks>
		public Result ConversionResult {
			get { return _conversionResult; }
			set { _conversionResult = value; }
		}

        /// <summary>
        /// The numerical value of this measurement
        /// </summary>
		public double Value {
			get { return _value; }
		}

        /// <summary>
        /// The unit symbol of this measurement
        /// </summary>
		public string Symbol {
			get {
				if (_unit == null) {
					return null;
				} else {
					return _symbol;
				}
			}
		}

		/// <summary>
        /// Gets the current value of the measurement in string form.
		/// </summary>
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
        /// <summary>
        /// Gets the value of the measurement in the specified units.
        /// </summary>
        /// <param name="unitSymbol"></param>
        /// <returns></returns>
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