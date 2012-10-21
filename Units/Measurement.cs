using System;
using System.Runtime.Serialization;
using System.Diagnostics.Contracts;

namespace Units
{

    [Serializable()]
    [DataContract()]
    [KnownType(typeof(Unit))]
    [KnownType(typeof(UnitType))]
    [KnownType(typeof(Symbol))]
    [KnownType(typeof(Modifier))]
    [KnownType(typeof(ConversionResult))]
    public struct Measurement : IEquatable<Measurement>, IComparable<Measurement>
    {

        #region "Private Fields"
        private MeasurementFlags _flags;

        private UnitConverter _uc;
        private double _maxbound;

        private double _minbound;
        private double _standardValue;
        private Unit _standardUnit;
        private double _value;
        private Unit _unit;

        private string _symbol;

        private Result _conversionResult;
        public event EventHandler OnValueChanged;
        public event EventHandler OnUnitChanged;
        #endregion

        #region "Constructors"
        internal Measurement(string unitSymbol)
        {
            //Reference the unit converter that created us.
            _uc = new UnitConverter();

            _flags = MeasurementFlags.None;


            if (string.IsNullOrWhiteSpace(unitSymbol))
            {
                //System.Diagnostics.Debug.Print("First IF Statement")
                _unit = null;
                _conversionResult = Result.BadUnit;
            }
            else
            {
                //System.Diagnostics.Debug.Print("First ELSE Statement")
                _unit = _uc.GetUnitBySymbol(unitSymbol);
                _conversionResult = Result.NoError;

                if (_unit.Symbols.Contains(new Symbol { Value = unitSymbol }))
                {
                    _symbol = unitSymbol;
                }
                else
                {
                    _symbol = _unit.DefaultSymbol;
                }
            }

            _value = 0;
        }

        public Measurement(double value, string unitSymbol)
            : this(unitSymbol)
        {

            if (!string.IsNullOrWhiteSpace(unitSymbol))
            {
                _unit = _uc.GetUnitBySymbol(unitSymbol);
            }

            _value = value;
        }

        internal Measurement(double value, string unitSymbol, Result ConversionResult)
            : this(unitSymbol)
        {

            _value = value;

            _conversionResult = ConversionResult;
        }

        internal Measurement(double value, Result ConversionResult)
            : this(null)
        {

            _value = value;

            _conversionResult = ConversionResult;
        }

        internal Measurement(double value, Unit unit, Result ConversionResult = Result.NoError)
        {
            //Reference the unit converter that created us.
            _uc = new UnitConverter();

            _flags = MeasurementFlags.None;

            _unit = unit;
            _conversionResult = Result.NoError;

            _value = value;

            _conversionResult = ConversionResult;
        }
        #endregion

        #region "measurement flags and properties methods"


        /// <summary>
        /// Gets a reference to the current unit of the measurement.
        /// </summary>
        public Unit Unit
        {
            get { return _unit; }
        }

        /// <summary>
        /// Gets or sets the flags on this measurement.
        /// </summary>
        public MeasurementFlags Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        /// <summary>
        /// Gets the unit converter associated with this measurement.
        /// </summary>
        public UnitConverter Converter
        {
            get { return _uc; }
        }

        /// <summary>
        /// Displays the result of a conversion
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks>This property will default to NoError unless after a conversion there were problems.</remarks>
        public Result ConversionResult
        {
            get { return _conversionResult; }
            set { _conversionResult = value; }
        }

        public double Value
        {
            get { return _value; }
        }

        public string Symbol
        {
            get
            {
                if (_unit == null)
                {
                    return null;
                }
                else
                {
                    return _symbol;
                }
            }
        }

        /// <summary>
        /// Gets the current value of the measurement in string form.
        /// </summary>
        /// <returns>Unit result value.</returns>
        public string FullValue
        {
            get
            {
                string str = _value.ToString();

                if (_unit != null)
                {
                    if (!string.IsNullOrEmpty(_unit.DefaultSymbol))
                    {
                        str += _unit.DefaultSymbol;
                    }
                    else
                    {
                        str += _unit.Name;
                    }
                }

                return str;
            }
        }

        public bool IsValid
        {
            get
            {
                if (_conversionResult != Result.NoError && _conversionResult != Result.UnitExists)
                {
                    return false;
                }
                else if (_uc == null)
                {
                    return false;
                }
                else if (_unit == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        #endregion

        #region "Value getting and setting methods"
        /// <summary>
        /// Sets the unit of the measurement.
        /// </summary>
        /// <param name="unitSymbol">Symbol of unit to set the measurement to.</param>
        /// <returns>Unit result value.</returns>
        internal Result SetUnit(string unitSymbol)
        {
            Unit unit = _uc.GetUnitBySymbol(unitSymbol);

            if (unit == null)
            {
                return Result.BadUnit;
            }
            else
            {
                //If its the same don't touch it.
                if (unit.DefaultSymbol == _unit.DefaultSymbol)
                {
                    return Result.NoError;
                }

                _unit = unit;

                //If OnUnitChanged <> Nothing Then
                if (OnUnitChanged != null)
                {
                    OnUnitChanged(this, EventArgs.Empty);
                }
                //End If

                return Result.NoError;
            }
        }

        /// <summary>
        /// Given a string in the format "[value] [unit]" parses and applies the value and unit.
        /// </summary>
        /// <param name="measurement">Formatted string containing value and unit.</param>
        /// <returns>Unit result code.</returns>
        internal Result SetValue(string measurement)
        {
            if (string.IsNullOrEmpty(measurement))
            {
                throw new ArgumentNullException("measurement");
            }
            Contract.EndContractBlock();

            double d = 0;
            string symbol = null;
            Result res = default(Result);

            res = ValidateEntry(measurement);
            if (res != Result.NoError)
            {
                return res;
            }

            Measurement newRes = _uc.ParseUnitString(measurement);

            d = newRes.Value;
            symbol = newRes.Symbol;

            //Can we change the unit?
            if ((_flags & MeasurementFlags.ForceUnit) > 0)
            {
                //Cant change the unit, so turn the given units into the unit we want
                Measurement convRes = _uc.ConvertUnits(d, symbol, _unit.Name);
                d = convRes.Value;
            }
            else
            {
                //Change the measurement unit to the given unit.
                SetUnit(symbol);
            }

            SetValue(d);
            return res;
        }

        /// <summary>
        /// Sets a value in the currently set unit format.
        /// </summary>
        /// <param name="value">Value to set the measurement to.</param>
        /// <returns>Unit result code.</returns>
        internal Result SetValue(double value)
		{
			Measurement res = default(Measurement);
			Unit standardUnit = default(Unit);
			UnitType tp = _unit.UnitType;
			standardUnit = (from un in tp.Units where un.IsDefault == true).FirstOrDefault;
			res = _uc.ConvertUnits(value, _unit.Name, standardUnit.Name);

			_value = value;
			_standardValue = res.Value;

			if (res.ConversionResult != Result.NoError) {
				return res.ConversionResult;
			}

			if (OnValueChanged != null) {
				OnValueChanged(this, EventArgs.Empty);
			}

			return res.ConversionResult;
		}

        /// <summary>
        /// Gets the value of the measurement in the specified units.
        /// </summary>
        /// <param name="unitSymbol">Symbol of the unit to retrieve the data in.</param>
        /// <returns>Unit result value.</returns>
        public Measurement GetValueAs(string unitSymbol)
        {
            return _uc.ConvertUnits(_value, _unit.Name, unitSymbol);
        }

        public string GetStringValueAs(string unitSymbol)
        {
            Measurement res = default(Measurement);
            res = _uc.ConvertUnits(_value, _unit.Name, unitSymbol);

            if (res.ConversionResult != Result.NoError)
            {
                return "Conversion Error";
            }
            else
            {
                return res.FullValue;
            }
        }
        #endregion

        #region "Validation methods"
        /// <summary>
        /// Validates input to the measurement.
        /// </summary>
        /// <param name="entry">String to validate (in the form "[value] [unit]").</param>
        /// <returns>Unit result value.</returns>
        public Result ValidateEntry(string entry)
        {
            string unit = null;
            double d = 0;
            Measurement res = default(Measurement);

            //Parse the entry
            res = _uc.ParseUnitString(entry);
            if (res.ConversionResult != Result.NoError)
            {
                return res.ConversionResult;
            }

            unit = res.Symbol;
            d = res.Value;

            return ValidateEntryUnitData(unit, d);
        }

        public Result ValidateEntry(double value, string symbol)
        {
            return ValidateEntryUnitData(symbol, value);
        }

        private Result ValidateEntryUnitData(string unit, double x)
        {

            //Make sure the units are compatible
            if (!_uc.IsCompatible(unit, this._unit.DefaultSymbol))
            {
                return Result.UnitMismatch;
                //New ConversionResult(0, Result.UnitMismatch)
            }

            Measurement newRes = _uc.ConvertUnits(x, unit, this.Unit.Name);
            x = newRes.Value;

            if ((this._flags & MeasurementFlags.UseMaxBound) > 0)
            {
                if (x > this._maxbound)
                {
                    return Result.ValueTooHigh;
                    //New ConversionResult(0, Result.ValueTooHigh)
                }
            }

            if ((this._flags & MeasurementFlags.UseMinBound) > 0)
            {
                if (x < this._minbound)
                {
                    return Result.ValueTooLow;
                    //New ConversionResult(0, Result.ValueTooLow)
                }
            }

            return Result.NoError;
            //New ConversionResult(x, unit)
        }

        #endregion

        #region "Bounds setting methods"
        /// <summary>
        /// Sets the maximum bound of the measurement.
        /// </summary>
        /// <param name="maxbound">Value of the maximum bound.</param>
        /// <param name="unitSymbol">The units the maximum bound is given in.</param>
        /// <returns>Unit result value.</returns>
        public Result SetMaxBound(double maxbound, string unitSymbol)
        {
            if (string.IsNullOrEmpty(unitSymbol))
            {
                throw new ArgumentNullException("unitSymbol");
            }

            if (!_uc.IsCompatible(unitSymbol, this._unit.DefaultSymbol))
            {
                return Result.UnitMismatch;
                //New ConversionResult(Result.UnitMismatch)
            }

            Measurement res = _uc.ConvertUnits(maxbound, unitSymbol, _unit.Name);
            //_uc.ConvertToStandard(maxbound, unitSymbol)

            this._maxbound = res.Value;

            return Result.NoError;
            //New ConversionResult(Result.NoError)
        }

        /// <summary>
        /// Sets the minimum bound of the measurement.
        /// </summary>
        /// <param name="minbound">Value of the minimum bound.</param>
        /// <param name="unitSymbol">The units the minimum bound is given in.</param>
        /// <returns>Unit result value.</returns>
        public Result SetMinBound(double minbound, string unitSymbol)
        {
            if (string.IsNullOrEmpty(unitSymbol))
            {
                throw new ArgumentNullException("unitSymbol");
            }

            if (!_uc.IsCompatible(unitSymbol, this._unit.DefaultSymbol))
            {
                return Result.UnitMismatch;
                //New ConversionResult(Result.UnitMismatch)
            }

            Measurement res = _uc.ConvertUnits(minbound, unitSymbol, _unit.Name);
            //_uc.ConvertToStandard(minbound, unitSymbol)

            this._minbound = res.Value;

            return Result.NoError;
            //New ConversionResult(Result.NoError)
        }
        #endregion

        #region "Operator overloads"
        /// <summary>
        /// Gets a string representation of the measurement.
        /// </summary>
        /// <returns>The string representation of the measurement.</returns>
        public override string ToString()
        {
            return this.FullValue;
        }

        /// <summary>
        /// Adds two measurements together.
        /// </summary>
        public static Measurement operator +(Measurement d1, Measurement d2)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            x = d1.Value;

            if (d2.Unit.ID == d1.Unit.ID)
            {
                y = d2.Value;
            }
            else
            {
                y = d2.Value;
                Measurement res2 = d2.Converter.ConvertUnits(y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
                y = res2.Value;
            }

            object result = new Measurement(x + y, d1.Unit);
            return result;
        }

        /// <summary>
        /// Subtracts two measurements.
        /// </summary>
        public static Measurement operator -(Measurement d1, Measurement d2)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            x = d1.Value();

            if (d2.Unit.ID == d1.Unit.ID)
            {
                y = d2.Value;
            }
            else
            {
                y = d2.Value;
                Measurement res2 = d2.Converter.ConvertUnits(y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
                y = res2.Value;
            }

            object result = new Measurement(x - y, d1.Unit);
            return result;
        }

        /// <summary>
        /// Multiplies two measurements.
        /// </summary>
        public static Measurement operator *(Measurement d1, Measurement d2)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            x = d1.Value();

            if (d2.Unit.ID == d1.Unit.ID)
            {
                y = d2.Value;
            }
            else
            {
                y = d2.Value;
                Measurement res2 = d2.Converter.ConvertUnits(y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
                y = res2.Value;
            }

            object result = new Measurement(x * y, d1.Unit);
            return result;
        }

        /// <summary>
        /// Divides two measurements.
        /// </summary>
        public static Measurement operator /(Measurement d1, Measurement d2)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            x = d1.Value();

            if (d2.Unit.ID == d1.Unit.ID)
            {
                y = d2.Value;
            }
            else
            {
                y = d2.Value;
                Measurement res2 = d2.Converter.ConvertUnits(y, d2.Unit.DefaultSymbol, d1.Unit.DefaultSymbol);
                y = res2.Value;
            }

            object result = new Measurement(x / y, d1.Unit);
            return result;
        }

        public static bool operator !=(Measurement left, Measurement right)
        {
            return !left.Equals(right);
        }

        public static bool operator ==(Measurement left, Measurement right)
        {
            return left.Equals(right);
        }

        public static bool operator <(Measurement left, Measurement right)
        {
            return (left.CompareTo(right) < 0);
        }

        public static bool operator >(Measurement left, Measurement right)
        {
            return (left.CompareTo(right) > 0);
        }

        public static bool operator <=(Measurement left, Measurement right)
        {
            return (left.CompareTo(right) <= 0);
        }

        public static bool operator >=(Measurement left, Measurement right)
        {
            return (left.CompareTo(right) >= 0);
        }
        #endregion

        #region "IEquatable(Of Measurement)"
        public override int GetHashCode()
		{
			Measurement MeRes = default(Measurement);
			string str = string.Empty;
			if (this.ConversionResult != Result.NoError) {
				str = this.Value.ToString + "|" + this.ConversionResult.ToString;
			} else {
				Unit standardUnit = default(Unit);
				UnitType tp = this.Unit.UnitType;
				standardUnit = (from un in tp.Unitswhere un.IsDefault == true).FirstOrDefault;

				MeRes = this.Converter.ConvertUnits(this._value, this.Unit.DefaultSymbol, standardUnit.DefaultSymbol);
				str = MeRes.Value.ToString + "|" + MeRes.Symbol;
			}

			return str.GetHashCode;
		}

        public override bool Equals(object obj)
        {
            if (obj == null || !object.ReferenceEquals(obj.GetType, typeof(Measurement)))
            {
                return false;
            }

            Measurement Mobj = (Measurement)obj;
            return this.Equals(Mobj);
        }

        public bool Equals(Measurement other)
        {
            if (other.ConversionResult != Result.NoError)
            {
                return false;
            }

            if (this.ConversionResult != Result.NoError)
            {
                return false;
            }

            if (this.Unit == null && other.Unit == null)
            {
                return true;
            }

            if (this.Unit == null ^ other.Unit == null)
            {
                return false;
            }

            //Dim standardUnit As Unit
            //Dim tp As UnitType = Me.Unit.UnitType
            //standardUnit = (From un In tp.Units _
            //                Where un.IsDefault = True).FirstOrDefault

            if (this.Unit.Name == other.Unit.Name && this.Value == other.Value)
            {
                return true;
            }
            else
            {
                Measurement OtherRes = other.Converter.ConvertUnits(other._value, other.Unit.Name, this.Unit.Name);

                if (OtherRes.ConversionResult != Result.NoError)
                {
                    return false;
                }
                else if (this.Unit.Name != OtherRes.Unit.Name)
                {
                    return false;
                }
                else if (this.Value != OtherRes.Value)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        #endregion

        #region "ICompareTo(Of Measurement)"
        public int CompareTo(Measurement other)
		{
			if (other.ConversionResult != Result.NoError) {
				throw new ArgumentException("other", "the 'other' parameter must have a valid value");
			}

			if (this.ConversionResult != Result.NoError) {
				throw new ArgumentException("this", "object must have a valid value");
			}

			Unit standardUnit = default(Unit);
			UnitType tp = this.Unit.UnitType;
			standardUnit = (from un in tp.Unitswhere un.IsDefault == true).FirstOrDefault;

			Unit OtherStandardUnit = default(Unit);
			tp = this.Unit.UnitType;
			OtherStandardUnit = (from un in tp.Unitswhere un.IsDefault == true).FirstOrDefault;

			Measurement MeRes = this.Converter.ConvertUnits(this._value, this.Unit.DefaultSymbol, standardUnit.DefaultSymbol);
			Measurement OtherRes = other.Converter.ConvertUnits(other._value, other.Unit.DefaultSymbol, OtherStandardUnit.DefaultSymbol);

			if (MeRes.Symbol != OtherRes.Symbol) {
				throw new ArgumentException("The parameter must be of the same unit type as this object. " + this.Unit.DefaultSymbol, "other");
			}

			return MeRes.Value.CompareTo(OtherRes.Value);
		}
        #endregion
    }
}

