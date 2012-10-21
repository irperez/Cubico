using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Units
{
    
    public class UnitConverter
    {

        //TODO: Fix this; was Previously NaN
        public const double FAILSAFE_VALUE = 0;

        private Dictionary<string, Unit> _SymbolDictionary;
        private Dictionary<string, Symbol> _IndividualSymbolDictionary;
        private Dictionary<string, Unit> _UnitDictionary;

        private Dictionary<string, UnitType> _UnitTypeDictionary;
        private string _CurUnitFileName;

        private double _CurUnitsFileVersion;
        /// <summary>
        /// Called when an error occurs in the unit converter.
        /// </summary>
        public event EventHandler OnError;

        /// <summary>
        /// Constructor, sets up the unit converter.
        /// </summary>
        public UnitConverter()
        {
            //Set up the tables we need
            UnitProvider unitPro = new UnitProvider();
            _SymbolDictionary = unitPro.Symbols;
            _IndividualSymbolDictionary = unitPro.IndividualSymbols;
            _UnitDictionary = unitPro.Units;
            _UnitTypeDictionary = unitPro.UnitTypes;

            //Create an Xml document to hold the units file in.
            _CurUnitsFileVersion = 0;

            _CurUnitFileName = "";
        }

        #region "Unit related methods"
        /// <summary>
        /// Given the full name of the unit, returns the unit entry.
        /// </summary>
        /// <param name="unitName">Name of the unit.</param>
        /// <returns>Reference to the unit entry, or null if not found.</returns>
        public Unit GetUnitByName(string unitName)
        {
            if (string.IsNullOrEmpty(unitName))
            {
                throw new ArgumentException("unitName must have a value.");
            }

            if (this._UnitDictionary.ContainsKey(unitName))
            {
                return this._UnitDictionary[unitName];
            }
            else
            {
                throw new ArgumentException("The unit '" + unitName + "' was not found in the UnitConverter.  Add this unit to the database for compatability.");
            }
        }

        /// <summary>
        /// Given a unit symbol, gets the unit entry.
        /// </summary>
        /// <param name="unitSymbol">Symbol of the unit.</param>
        /// <returns>Reference to the unit entry, or null if symbol does not exist.</returns>
        public Unit GetUnitBySymbol(string unitSymbol)
		{
			if (string.IsNullOrWhiteSpace(unitSymbol)) {
				throw new ArgumentNullException("unitSymbol must have a value");
			}

			//First check to see if they used the actual name of a unit then look at the symbol table.
			Unit unitFound = (from val in this._UnitDictionary.Values where val.Name.ToUpper() == unitSymbol.Trim().ToUpper() select val).FirstOrDefault();

			if (unitFound != null) {
				return unitFound;
			}

			Symbol symFound = (from val in this._IndividualSymbolDictionary.Values where val.Value == unitSymbol.Trim() select val).FirstOrDefault();

			if (symFound != null) {
				return symFound.Unit;
			}

			throw new ArgumentException("The unit/symbol '" + unitSymbol + "' was not found in the UnitConverter.  Add this unit to the database for compatability.");

		}
        #endregion

        #region "Group related methods"
        /// <summary>
        /// Gets a value that determines whether the given units are compatible or not.
        /// </summary>
        /// <param name="leftSymbol">Symbol for the first unit.</param>
        /// <param name="rightSymbol">Symbol for the second unit.</param>
        /// <returns>True if units are compatible, else false.</returns>
        public bool IsCompatible(string leftSymbol, string rightSymbol)
        {
            if (string.IsNullOrEmpty(leftSymbol) || string.IsNullOrEmpty(rightSymbol))
            {
                throw new ArgumentException("The left and right symbol values cannot be empty or null.");
            }
            Contract.EndContractBlock();

            Unit leftUnit = this.GetUnitBySymbol(leftSymbol);
            Unit rightUnit = this.GetUnitBySymbol(rightSymbol);

            if ((leftUnit == null) || (rightUnit == null))
            {
                return false;
            }

            return (this.GetUnitType(leftUnit.Name) == this.GetUnitType(rightUnit.Name));
        }

        /// <summary>
        /// Creates a new unit group and adds it to the group table.
        /// </summary>
        /// <param name="groupName">Name of the new group.</param>
        /// <returns>Unit result value.</returns>
        private Result CreateNewGroup(string groupName)
        {
            //Create the new group
            UnitType newType = new UnitType();
            newType.Name = groupName;

            //Add it to the group table
            this._UnitTypeDictionary.Add(groupName, newType);

            return Result.NoError;
        }

        /// <summary>
        /// Adds the named unit to the specified group.
        /// </summary>
        /// <param name="unitName">Name of the unit.</param>
        /// <param name="unitTypeName">Name of the group to add the unit to.</param>
        /// <returns>Unit result value.</returns>
        private Result AddUnitToGroup(string unitName, string unitTypeName)
        {
            Unit unit = this._UnitDictionary[unitName];
            UnitType group = this._UnitTypeDictionary[unitTypeName];

            //Make sure the unit exists.
            if (unit == null)
            {
                return Result.UnitNotFound;
            }

            //Make sure the group exists.
            if (group == null)
            {
                return Result.GroupNotFound;
            }

            //Add the unit.
            group.Units.Add(unit);

            return Result.NoError;
        }

        /// <summary>
        /// Given the name of a unit, searches for the unit group it belongs to.
        /// </summary>
        /// <param name="unitName">Name of the unit.</param>
        /// <returns>The group the unit is in, or null if the unit is not valid.</returns>
        private UnitType GetUnitType(string unitName)
		{
			if (string.IsNullOrEmpty(unitName)) {
				throw new ArgumentException("unitName must have a value");
			}
			Contract.EndContractBlock();

			//Does the unit even exist?
			if (this._UnitDictionary.ContainsKey(unitName) == false) {
				return null;
			} else {
				//Iterate through every group
				UnitProvider unitPro = new UnitProvider();
				foreach (KeyValuePair<string, UnitType> ut in unitPro.UnitTypes) {
					if (ut.Value.Units.Contains(new Unit { Name = unitName })) {
						return ut.Value;
					}
				}
				return null;
			}
		}
        #endregion

        #region "Conversion methods"

        /// <summary>
        /// Performs a unit conversion between two units, given a value to convert.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="currentUnitName">The name of the unit the value is currently in.</param>
        /// <param name="targetUnitName">The name of the unit that the value is to be converted to.</param>
        /// <returns>Unit result value.</returns>
        public Measurement ConvertUnits(double value, string currentUnitName, string targetUnitName)
        {
            double x = value;

            //Default to the fail safe value.
            double output = 0;
            output = FAILSAFE_VALUE;

            if (string.IsNullOrEmpty(currentUnitName) || string.IsNullOrEmpty(targetUnitName))
            {
                return new Measurement(0, Result.BadUnit);
            }

            Unit currentUnit = GetUnitBySymbol(currentUnitName);
            Unit targetUnit = GetUnitBySymbol(targetUnitName);

            //Make sure both units are real units.
            if ((currentUnit == null) || (targetUnit == null))
            {
                return new Measurement(output, Result.BadUnit);
            }

            //Make sure the units are of the same group
            if (!this.IsCompatible(currentUnit.Name, targetUnit.Name))
            {
                return new Measurement(output, Result.UnitMismatch);
            }

            return ConvertCurrentToTarget(x, currentUnit.Name, targetUnit.Name);
        }

        /// <summary>
        /// Performs a unit conversion from the standard value into the specified unit.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="targetUnitName">The name of the unit that the value is to be converted to.</param>
        /// <returns>Unit result value.</returns>
        public Measurement ConvertCurrentToTarget(double value, string currentUnitName, string targetUnitName)
		{
			double x = value;

			//Default to the fail safe value.
			double output = 0;
			output = FAILSAFE_VALUE;

			if (string.IsNullOrEmpty(targetUnitName)) {
				return new Measurement(0, Result.BadUnit);
			}

			Unit currentUnit = GetUnitBySymbol(currentUnitName);
			Unit targetUnit = GetUnitBySymbol(targetUnitName);

			//Make sure both units are real units.
			if (targetUnit == null) {
				return new Measurement(output, Result.BadUnit);
			}

			try {
				IOrderedEnumerable<Modifier> moders = from m in targetUnit.Modifiers 
                                                    where m.UnitSourceID == currentUnit.ID && m.UnitTargetID == targetUnit.ID 
                                                    orderby m.Order
                                                    select m;

				foreach (var moder in moders) 
                {
					int m_intPrecision = 15;

					if (moder.Precision != null) {
						m_intPrecision = Convert.ToInt32(moder.Precision);
					}

					switch (moder.ModifierType) {
						case ModifierType.PreAdd:
							x = x - (double)moder.Value;
							break;
						case ModifierType.Multiply:
							if (moder.Value > 0) {
								x = System.Math.Round(x * (double)moder.Value, m_intPrecision);
							}
							break;
						case ModifierType.Divide:
							if (moder.Value > 0) {
								x = System.Math.Round(x / (double)moder.Value, m_intPrecision);
							}
							break;
						case ModifierType.Add:
							x = System.Math.Round(x + (double)moder.Value, m_intPrecision);
							break;
						case ModifierType.Subtract:
							x = System.Math.Round(x - (double)moder.Value, m_intPrecision);
							break;
					}
				}

				output = x;
			} catch {
				//Probably overflowed or something.
				return new Measurement(output, Result.BadValue);
			}

			return new Measurement(output, targetUnit);
		}

        #endregion

        #region "Parsing routines"

        // TO DO: Implement ParseNumberString.

        // ''' <summary>
        // ''' Parses a number string with operators.
        // ''' </summary>
        // ''' <param name="input">String containing numbers and operators.</param>
        // ''' <returns>Unit result code.</returns>
        //Private Function ParseNumberString(ByVal input As String) As ConversionResult
        //    If String.IsNullOrEmpty(input) Then
        //        Throw New ArgumentException("input must have a value")
        //    End If

        //    'Default value
        //    Dim value As Double
        //    value = 0

        //    'Split the numbers on the ^ operator
        //    Dim numbers As String()
        //    numbers = input.Split(New Char() {"^"c})

        //    If numbers.Length = 1 Then
        //        'Only one value, so there was no ^ operator present
        //        'so just return the one number.
        //        Try
        //            value = Convert.ToDouble(numbers(0))
        //        Catch
        //            Return New ConversionResult(0, Result.BadValue)
        //        End Try
        //    Else
        //        'There is a ^ operator, so try to use it.
        //        Try
        //            value = Convert.ToDouble(numbers(0))
        //            value = CDbl(System.Math.Pow(value, Convert.ToDouble(numbers(1))))
        //        Catch
        //            Return New ConversionResult(0, Result.BadValue)
        //        End Try
        //    End If

        //    Return New ConversionResult(value)
        //End Function


        /// <summary>
        /// Given a string in the format "[value] [unit]", splits and returns the parts.
        /// </summary>
        /// <param name="input">Input string in the format "[value] [unit]" to be parsed.</param>
        /// <returns>Unit result code.</returns>
        public Measurement ParseUnitString(string input)
        {
            //Defaults
            double value = 0;
            string symbol = null;
            value = 0;
            symbol = "";

            if (string.IsNullOrEmpty(input))
            {
                return new Measurement(0, Result.BadValue);
            }

            int i = 0;

            string s1 = "";
            string s2 = "";

            //Look for the first letter or punctuation character.
            i = 0;
            while (i < input.Length)
            {
                if (Char.IsLetter(input, i) || char.IsPunctuation(input, i) || char.IsSymbol(input, i))
                {
                    if (input[i] != Convert.ToChar(".") && input[i] != Convert.ToChar("-"))
                    {
                        break; // TODO: might not be correct. Was : Exit While
                    }
                }
                System.Math.Max(System.Threading.Interlocked.Increment(ref i), i - 1);
            }

            s1 = input.Substring(0, i);
            s1 = s1.Trim();
            s2 = input.Substring(i);
            s2 = s2.Trim();

            //No value? default to 0
            if (string.IsNullOrEmpty(s1))
            {
                s1 = "0";
            }

            try
            {
                value = Convert.ToDouble(s1);
            }
            catch
            {
                return new Measurement(0, Result.BadValue);
            }

            try
            {
                this.GetUnitBySymbol(s2);
            }
            catch (Exception)
            {
                return new Measurement(0, Result.BadUnit);
            }

            symbol = s2;

            return new Measurement(value, symbol);
        }
        #endregion

    }
}

