using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Units
{
    public class UnitProvider 
    {

        #region "Constructors"
        public UnitProvider()
        {
        }
        #endregion

        #region "UnitTypes"

        //Singleton
        private static Dictionary<string, UnitType> _unitTypes;
        public Dictionary<string, UnitType> UnitTypes
        {
            get
            {
                if (_unitTypes == null)
                {
                    _unitTypes = GetAllUnitTypes();
                }
                return _unitTypes;
            }
        }

        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private Dictionary<string, UnitType> GetAllUnitTypes()
		{
			Dictionary<string, UnitType> unitTypes = new Dictionary<string, UnitType>();

            using (UnitEntities context = new UnitEntities(GenerateEntityConnection(DefaultConnectionName))) {
                object query = from ut in context.UnitTypes.Include("Units.Modifiers").Include("Units.Sources").Include("Units.Symbols") orderby ut.Name select ut;

                foreach (var itm in query) {
                    unitTypes.Add(itm.Name, itm);
                }

            }

			return unitTypes;
		}
        #endregion

        #region "Units"

        private Dictionary<string, Unit> _units;
        public Dictionary<string, Unit> Units
        {
            get
            {
                if (_units == null)
                {
                    _units = GetAllUnits();
                }
                return _units;
            }
        }

        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private Dictionary<string, Unit> GetAllUnits()
		{
			Dictionary<string, Unit> unitDict = new Dictionary<string, Unit>();
			UnitProvider unitPro = new UnitProvider();
			object query = from s in unitPro.UnitTypes;


			foreach (var itm in query) {
				UnitType ut = itm.Value;

				foreach (var un in ut.Units) {
					if (!unitDict.ContainsKey(un.Name)) {
						unitDict.Add(un.Name, un);
					}
				}
				//Units "Celsius"
			}
			//UnitTypes "Temperature"

			return unitDict;
		}
        #endregion

        #region "Symbols"
        private static Dictionary<string, Unit> _symbols;

        private static Dictionary<string, Symbol> _individualSymbols;
        public Dictionary<string, Unit> Symbols
        {
            get
            {
                if (_symbols == null)
                {
                    _symbols = GetAllSymbols();
                }
                return _symbols;
            }
        }

        public Dictionary<string, Symbol> IndividualSymbols
        {
            get
            {
                if (_individualSymbols == null)
                {
                    _individualSymbols = GetAllIndividualSymbols();
                }
                return _individualSymbols;
            }
        }

        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private Dictionary<string, Unit> GetAllSymbols()
		{
			Dictionary<string, Unit> unitDict = new Dictionary<string, Unit>();
			UnitProvider unitPro = new UnitProvider();

			object query = from s in unitPro.UnitTypes;


			foreach (var itm in query) {
				UnitType ut = itm.Value;


				foreach (var un in ut.Units) {
					Unit unit = un;

					if (unit.Symbols == null || unit.Symbols.Count == 0) {
						//No symbols.  Add name of unit as symbol.
						if (!unitDict.ContainsKey(unit.Name)) {
							unitDict.Add(unit.Name, unit);
						}
					} else {
						foreach (var sy in unit.Symbols) {
							if (!unitDict.ContainsKey(sy.Value)) {
								unitDict.Add(sy.Value, unit);
							}
						}
						//Symbols "C"

						if (!unitDict.ContainsKey(unit.Name)) {
							unitDict.Add(unit.Name, unit);
							//Add name as symbol just in case
						}
					}
				}
				//Units "Celsius"
			}
			//UnitTypes "Temperature"

			return unitDict;
		}


        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private Dictionary<string, Symbol> GetAllIndividualSymbols()
		{
			Dictionary<string, Symbol> unitDict = new Dictionary<string, Symbol>();
			UnitProvider unitPro = new UnitProvider();

			object query = from s in unitPro.UnitTypes;


			foreach (var itm in query) {
				UnitType ut = itm.Value;


				foreach (var un in ut.Units) {
					Unit unit = un;

					foreach (var us in unit.Symbols) {
						if (!unitDict.ContainsKey(us.Value)) {
							unitDict.Add(us.Value, us);
						}
					}

				}

			}

			return unitDict;
		}

        #endregion

    }
}