using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
//using W3b.Sine;

namespace Cubico
{
	public class UnitConverter
	{
		//TODO: Fix this; was Previously NaN
		const double _failsafeValue = 0;
		public Dictionary<string, Unit> _SymbolDictionary;
		Dictionary<string, Symbol> _IndividualSymbolDictionary;
		Dictionary<string, Unit> _UnitDictionary;
		Dictionary<string, UnitType> _UnitTypeDictionary;
		// Constructor, sets up the unit converter.
		public UnitConverter ()
		{
			//Set up the tables we need
			var unitPro = new UnitProvider ();
			_SymbolDictionary = unitPro.Symbols;
			_IndividualSymbolDictionary = unitPro.IndividualSymbols;
			_UnitDictionary = unitPro.Units;
			_UnitTypeDictionary = unitPro.UnitTypes;

		}
		#region "Unit related methods"
		// Given the full name of the unit, returns the unit entry.
		public Unit GetUnitByName (string unitName)
		{
			if (string.IsNullOrEmpty (unitName)) {
				throw new ArgumentException ("unitName must have a value.");
			}

			if (this._UnitDictionary.ContainsKey (unitName)) {
				return this._UnitDictionary [unitName];
			} else {
				throw new ArgumentException ("The unit '" + unitName + "' was not found in the UnitConverter.  Add this unit to the database for compatability.");
			}
		}
		// Given a unit symbol, gets the unit entry.
		public Unit GetUnitBySymbol (string unitSymbol)
		{
			if (string.IsNullOrWhiteSpace (unitSymbol)) {
				throw new ArgumentNullException ("unitSymbol must have a value");
			}

			//First check to see if they used the actual name of a unit then look at the symbol table.
			Unit unitFound = (from val in this._UnitDictionary.Values where val.Name.ToUpper () == unitSymbol.Trim ().ToUpper () select val).FirstOrDefault ();

			if (unitFound != null) {
				return unitFound;
			}

			Symbol symFound = (from val in this._IndividualSymbolDictionary.Values where val.Value == unitSymbol.Trim () select val).FirstOrDefault ();

			if (symFound != null) {
				return symFound.Unit;
			}

			throw new ArgumentException ("The unit/symbol '" + unitSymbol + "' was not found in the UnitConverter.  Add this unit to the database for compatability.");

		}
		#endregion
		#region "Group related methods"
		// Gets a value that determines whether the given units are compatible or not.
		public bool IsCompatible (string leftSymbol, string rightSymbol)
		{
			if (string.IsNullOrEmpty (leftSymbol) || string.IsNullOrEmpty (rightSymbol)) {
				throw new ArgumentException ("The left and right symbol values cannot be empty or null.");
			}
			Contract.EndContractBlock ();

			Unit leftUnit = this.GetUnitBySymbol (leftSymbol);
			Unit rightUnit = this.GetUnitBySymbol (rightSymbol);

			if ((leftUnit == null) || (rightUnit == null)) {
				return false;
			}

			return (this.GetUnitType (leftUnit.Name) == this.GetUnitType (rightUnit.Name));
		}
		// Creates a new unit group and adds it to the group table.
		Result CreateNewGroup (string groupName)
		{
			//Create the new group
			var newType = new UnitType { Name = groupName };

			//Add it to the group table
			this._UnitTypeDictionary.Add (groupName, newType);

			return Result.NoError;
		}
		// Adds the named unit to the specified group.
		Result AddUnitToGroup (string unitName, string unitTypeName)
		{
			Unit unit = this._UnitDictionary [unitName];
			UnitType group = this._UnitTypeDictionary [unitTypeName];

			//Make sure the unit exists.
			if (unit == null) {
				return Result.UnitNotFound;
			}

			//Make sure the group exists.
			if (group == null) {
				return Result.GroupNotFound;
			}

			//Add the unit.
			group.Units.Add (unit);

			return Result.NoError;
		}
		// Given the name of a unit, searches for the unit group it belongs to.
		UnitType GetUnitType (string unitName)
		{
			if (string.IsNullOrEmpty (unitName)) {
				throw new ArgumentException ("unitName must have a value");
			}
			Contract.EndContractBlock ();

			//Does the unit even exist?
			if (this._UnitDictionary.ContainsKey (unitName) == false) {
				return null;
			} else {
				//Iterate through every group
				var unitPro = new UnitProvider ();
				foreach (var ut in unitPro.UnitTypes) {
					if (ut.Value.Units.Contains (new Unit { Name = unitName })) {
						return ut.Value;
					}
				}
				return null;
			}
		}
		#endregion
		#region "Conversion methods"
		// Performs a unit conversion between two units, given a value to convert.
		public Measurement ConvertUnits (double value, string currentUnitName, string targetUnitName)
		{
			double x = value;

			//Default to the fail safe value.
			double output = 0;
			output = _failsafeValue;

			if (string.IsNullOrEmpty (currentUnitName) || string.IsNullOrEmpty (targetUnitName)) {
				return new Measurement (0, Result.BadUnit);
			}

			Unit currentUnit = GetUnitBySymbol (currentUnitName);
			Unit targetUnit = GetUnitBySymbol (targetUnitName);

			//Make sure both units are real units.
			if ((currentUnit == null) || (targetUnit == null)) {
				return new Measurement (output, Result.BadUnit);
			}

			//Make sure the units are of the same group
			if (!this.IsCompatible (currentUnit.Name, targetUnit.Name)) {
				return new Measurement (output, Result.UnitMismatch);
			}

			return ConvertCurrentToTarget (x, currentUnit.Name, targetUnit.Name);
		}
		// Performs a unit conversion from the standard value into the specified unit.
		public Measurement ConvertCurrentToTarget (double value, string currentUnitName, string targetUnitName)
		{
			double x = value;

			//Default to the fail safe value.
			double output = 0;
			output = _failsafeValue;

			if (string.IsNullOrEmpty (targetUnitName)) {
				return new Measurement (0, Result.BadUnit);
			}

			Unit currentUnit = GetUnitBySymbol (currentUnitName);
			Unit targetUnit = GetUnitBySymbol (targetUnitName);

			//Make sure both units are real units.
			if (targetUnit == null) {
				return new Measurement (output, Result.BadUnit);
			}

			try {
				var moders = from m in targetUnit.Modifiers
                                                    where m.UnitSourceID == currentUnit.ID && m.UnitTargetID == targetUnit.ID
                                                    orderby m.Order
                                                    select m;

				foreach (var moder in moders) {
					int m_intPrecision = 15;

					if (moder.Precision != null) {
						m_intPrecision = Convert.ToInt32 (moder.Precision);
					}

					switch (moder.ModifierType) {
					case ModifierType.PreAdd:
						x = x - (double)moder.Value;
						break;
					case ModifierType.Multiply:
						if (moder.Value > 0) {
							x = System.Math.Round (x * (double)moder.Value, m_intPrecision);
                            
                            //var resultX = (new BigNumDec(x)) * (new BigNumDec((double)moder.Value));

                            //resultX.
						}
						break;
					case ModifierType.Divide:
						if (moder.Value > 0) {
							x = System.Math.Round (x / (double)moder.Value, m_intPrecision);
						}
						break;
					case ModifierType.Add:
						x = System.Math.Round (x + (double)moder.Value, m_intPrecision);
						break;
					case ModifierType.Subtract:
						x = System.Math.Round (x - (double)moder.Value, m_intPrecision);
						break;
					}
				}

				output = x;
			} catch {
				//Probably overflowed or something.
				return new Measurement (output, Result.BadValue);
			}

			return new Measurement (output, targetUnit);
		}
		#endregion
		#region "Parsing routines"
		// Parses a number string with operators.
		ConversionResult ParseNumberString (string input)
		{
			if (string.IsNullOrEmpty (input)) {
				throw new ArgumentException ("input must have a value");
			}

			//Default value
			double value = 0;
			value = 0;

			//Split the numbers on the ^ operator
			string[] numbers = null;
			numbers = input.Split (new char[] { '^' });

			if (numbers.Length == 1) {
				//Only one value, so there was no ^ operator present, so just return the one number.
				try {
					value = Convert.ToDouble (numbers [0]);
				} catch {
					return new ConversionResult (0, Result.BadValue);
				}
			} else {
				//There is a ^ operator, so try to use it.
				try {
					value = Convert.ToDouble (numbers [0]);
					value = Convert.ToDouble (System.Math.Pow (value, Convert.ToDouble (numbers [1])));
				} catch {
					return new ConversionResult (0, Result.BadValue);

				}
			}

			return new ConversionResult (value);
		}
		// Given a string in the format "[value] [unit]", splits and returns the parts.
		public Measurement ParseUnitString (string input)
		{
			//Defaults
			double value = 0;
			string symbol = null;
			value = 0;
			symbol = "";

			if (string.IsNullOrEmpty (input)) {
				return new Measurement (0, Result.BadValue);
			}

			int i = 0;

			string s1 = "";
			string s2 = "";

			//Look for the first letter or punctuation character.
			i = 0;
			while (i < input.Length) {
				if (Char.IsLetter (input, i) || char.IsPunctuation (input, i) || char.IsSymbol (input, i)) {
					if (input [i] != Convert.ToChar (".") && input [i] != Convert.ToChar ("-")) {
						break; // TODO: might not be correct. Was : Exit While
					}
				}
				System.Math.Max (System.Threading.Interlocked.Increment (ref i), i - 1);
			}

			s1 = input.Substring (0, i);
			s1 = s1.Trim ();
			s2 = input.Substring (i);
			s2 = s2.Trim ();

			//No value? default to 0
			if (string.IsNullOrEmpty (s1)) {
				s1 = "0";
			}

			try {
				value = Convert.ToDouble (s1);
			} catch {
				return new Measurement (0, Result.BadValue);
			}

			try {
				this.GetUnitBySymbol (s2);
			} catch (Exception) {
				return new Measurement (0, Result.BadUnit);
			}

			symbol = s2;

			return new Measurement (value, symbol);
		}
		#endregion
	}
}