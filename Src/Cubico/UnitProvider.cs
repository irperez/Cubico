using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#if !PCL
using System.Xml;
#endif

namespace Cubico
{
	// Facilitates the loading and caching of the unit of measure data.
	public class UnitProvider
	{
		#region "Constructors"
		public UnitProvider ()
		{
            if (_jsonObj == null)
            {
                this.LoadJsonDataFile();
            }
		}
		#endregion
		#region "Properties"
#if !PCL
		static XmlDocument _dataFile;

		protected XmlDocument DataFile {
			get{ return _dataFile;}
			set{ _dataFile = value;}
		}
#endif

        private Cubico.UnitData.RootObject _jsonObj;
		//Singleton
		static Dictionary<string, UnitType> _unitTypes;

		public Dictionary<string, UnitType> UnitTypes {
			get {
				if (_unitTypes == null) {
					GetAllUnitTypes ();
				}
				return _unitTypes;
			}
		}

		Dictionary<string, Unit> _units;

		public Dictionary<string, Unit> Units {
			get {
				if (_units == null) {
					_units = GetAllUnits ();
				}
				return _units;
			}
		}

		static Dictionary<int, List<Modifier>> _individualModifiers;
		static Dictionary<string, Unit> _symbols;
		static Dictionary<string, Symbol> _individualSymbols;
		static Dictionary<int, List<Symbol>> _symbolLookUp;

		public Dictionary<string, Unit> Symbols {
			get {
				if (_symbols == null) {
					_symbols = GetAllSymbols ();
				}
				return _symbols;
			}
		}
		#endregion
		#region "Methods"
		#region "File Load Methods"
#if !PCL
		private void LoadDataFile ()
		{
			const string fileName = "Cubico.UnitData.xml";
#if !NETSTANDARD1_6
            var assembly = Assembly.GetExecutingAssembly ();
#else
            var assembly = typeof(Cubico.Measurement).GetTypeInfo().Assembly;
#endif

            var stream = assembly.GetManifestResourceStream (fileName);

			if (stream == null) {
				throw new FileNotFoundException ("Cannot find unit data file", fileName);
			}

			_dataFile = new XmlDocument ();
			_dataFile.Load (stream);

			this.ProcessUnitConverterData ();
		}
#endif

            private void LoadJsonDataFile()
        {
            const string fileName = "Cubico.UnitData.json";
#if !NETSTANDARD1_6
            var assembly = Assembly.GetExecutingAssembly();
#else
            var assembly = typeof(Cubico.Measurement).GetTypeInfo().Assembly;
#endif

            //var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(fileName);

            if (stream == null)
            {
                throw new InvalidOperationException("Cannot find unit data file " + fileName);
            }

            string json = "";
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                json = reader.ReadToEnd();                
            }
            var settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;
            _jsonObj = JsonConvert.DeserializeObject<Cubico.UnitData.RootObject>(json, settings);
            ProcessUnitConverterData2(_jsonObj);
        }

        private void ProcessUnitConverterData2(Cubico.UnitData.RootObject RootObject)
        {
            var data = RootObject.UnitConverterData;
            //Load Modifier Data
            _individualModifiers = new Dictionary<int, List<Modifier>>();
            foreach (var itm in data.UnitModifiers.UnitModifier)
            {
                var mod = new Modifier();
                mod.ID = Convert.ToInt32(itm.ID);
                mod.Value = Convert.ToDecimal(itm.Value);
                mod.Order = Convert.ToInt32(itm.Order);
                mod.ModifierType = (ModifierType)Convert.ToInt32(itm.ModifierID);
                mod.UnitSourceID = Convert.ToInt32(itm.UnitSourceID);
                mod.UnitTargetID = Convert.ToInt32(itm.UnitTargetID);

                if (string.IsNullOrWhiteSpace(itm.Precision))
                {
                    mod.Precision = null;
                }
                else
                {
                    mod.Precision = Convert.ToInt32(itm.Precision);
                }
                

                if (_individualModifiers.ContainsKey(mod.UnitTargetID))
                {
                    var modList = _individualModifiers[mod.UnitTargetID];
                    modList.Add(mod);
                }
                else
                {
                    var modList = new List<Modifier> { mod };
                    _individualModifiers.Add(mod.UnitTargetID, modList);
                }
            }

            //Load Symbol Data
            _symbolLookUp = new Dictionary<int, List<Symbol>>();
            foreach (var itm in data.Symbols.UnitSymbol)
            {
                var sym = new Symbol();
                sym.Id = Convert.ToInt32(itm.ID);
                sym.Value = itm.Symbol;
                sym.UnitId = Convert.ToInt32(itm.UnitID);
                int value = Convert.ToInt32(itm.IsDefault);
                if (value == 1)
                    sym.IsDefault = true;
                else
                    sym.IsDefault = false;

                if (_symbolLookUp.ContainsKey(sym.UnitId))
                {
                    var symList = _symbolLookUp[sym.UnitId];
                    symList.Add(sym);
                }
                else
                {
                    var symList = new List<Symbol> { sym };
                    _symbolLookUp.Add(sym.UnitId, symList);
                }
            }

            _units = new Dictionary<string, Unit>();
            foreach (var itm in data.Units.Unit)
            {
                var unit = new Unit();
                unit.ID = Convert.ToInt32(itm.ID);
                unit.Name = itm.Name;
                unit.UnitTypeID = Convert.ToInt32(itm.UnitTypeID);

                if (_symbolLookUp.ContainsKey(unit.ID))
                {
                    unit.Symbols = _symbolLookUp[unit.ID];

                    foreach (Symbol sym in unit.Symbols)
                    {
                        sym.Unit = unit;
                    }
                }
                if (_individualModifiers.ContainsKey(unit.ID))
                {
                    unit.Modifiers = _individualModifiers[unit.ID];

                    foreach (Modifier mod in unit.Modifiers)
                    {
                        mod.ParentUnit = unit;
                    }
                }
                _units.Add(unit.Name, unit);
            }

            //Load Unit Types
            _unitTypes = new Dictionary<string, UnitType>();
            foreach (var itm in data.UnitTypes.UnitType)
            {
                var ut = new UnitType();
                ut.ID = Convert.ToInt32(itm.ID);
                ut.Name = itm.Name;
                ut.Description = itm.Description;

                // Make this a for loop for speed reasons or use a multikey dictionary.
                var unitData = (from unit in _units.Values
                                where unit.UnitTypeID == ut.ID
                                select unit).ToList();
                ut.Units = unitData;

                foreach (Unit unitItem in ut.Units)
                {
                    unitItem.UnitType = ut;
                }

                _unitTypes.Add(ut.Name, ut);
            }
        }

#if !PCL
		void ProcessUnitConverterData ()
		{
			foreach (XmlNode node in this.DataFile.ChildNodes) {
				if (node.Name == "UnitConverterData") {
					ProcessDataTypes (node);
				}
			}
		}

		void ProcessDataTypes (XmlNode parentNode)
		{
			foreach (XmlNode node in parentNode.ChildNodes) {
				switch (node.Name) {
				case "UnitTypes":
					ProcessUnitTypes (node);
					break;
				case "Units":
					ProcessUnits (node);
					break;
				case "Symbols":
					ProcessUnitSymbols (node);
					break;
				case "UnitModifiers":
					ProcessUnitModifiers (node);
					break;
				}
			}
		}

		void ProcessUnitModifiers (XmlNode parentNode)
		{
			_individualModifiers = new Dictionary<int, List<Modifier>> ();

			foreach (XmlNode node in parentNode.ChildNodes) {
				if (node.Name == "UnitModifier") {
					var mod = new Modifier ();

					foreach (XmlAttribute attrib in node.Attributes) {
						switch (attrib.Name) {
						case "ID":
							mod.ID = Convert.ToInt32 (attrib.Value);
							break;
						case "Value":
							mod.Value = Convert.ToDecimal (attrib.Value);
							break;
						case "Order":
							mod.Order = Convert.ToInt32 (attrib.Value);
							break;
						case "ModifierID":
							mod.ModifierType = (ModifierType)Convert.ToInt32 (attrib.Value);
							break;
						case "UnitSourceID":
							mod.UnitSourceID = Convert.ToInt32 (attrib.Value);
							break;
						case "UnitTargetID":
							mod.UnitTargetID = Convert.ToInt32 (attrib.Value);
							break;
						case "Precision":
							mod.Precision = Convert.ToInt32 (attrib.Value);
							break;
						}

					}

					if (_individualModifiers.ContainsKey (mod.UnitTargetID)) {
						var data = _individualModifiers [mod.UnitTargetID];
						data.Add (mod);
					} else {
						var data = new List<Modifier> { mod };
						_individualModifiers.Add (mod.UnitTargetID, data);
					}

				}
			}
		}

		void ProcessUnitSymbols (XmlNode parentNode)
		{
			_symbolLookUp = new Dictionary<int, List<Symbol>> ();
			foreach (XmlNode node in parentNode.ChildNodes) {
				if (node.Name == "UnitSymbol") {
					var sym = new Cubico.Symbol ();

					foreach (XmlAttribute attrib in node.Attributes) {
						switch (attrib.Name) {
						case "ID":
							sym.Id = Convert.ToInt32 (attrib.Value);
							break;
						case "Symbol":
							sym.Value = attrib.Value;
							break;
						case "UnitID":
							sym.UnitId = Convert.ToInt32 (attrib.Value);
							break;
						case "IsDefault":
							int value = Convert.ToInt32 (attrib.Value);
							if (value == 1)
								sym.IsDefault = true;
							else
								sym.IsDefault = false;

							break;
						}

					}

					if (_symbolLookUp.ContainsKey (sym.UnitId)) {
						var data = _symbolLookUp [sym.UnitId];
						data.Add (sym);
					} else {
						var data = new List<Symbol> { sym };
						_symbolLookUp.Add (sym.UnitId, data);
					}
				}
			}
		}

		void ProcessUnits (XmlNode parentNode)
		{
			_units = new Dictionary<string, Unit> ();
			foreach (XmlNode node in parentNode.ChildNodes) {

				if (node.Name == "Unit") {
					var unit = new Unit ();

					foreach (XmlAttribute attrib in node.Attributes) {
						switch (attrib.Name) {
						case "ID":
							unit.ID = Convert.ToInt32 (attrib.Value);
							break;
						case "Name":
							unit.Name = attrib.Value;
							break;
						case "UnitTypeID":
							unit.UnitTypeID = Convert.ToInt32 (attrib.Value);
							break;
						}

					}

					if (_symbolLookUp.ContainsKey (unit.ID)) {
						unit.Symbols = _symbolLookUp [unit.ID];

						foreach (Symbol sym in unit.Symbols) {
							sym.Unit = unit;
						}
					}
					if (_individualModifiers.ContainsKey (unit.ID)) {
						unit.Modifiers = _individualModifiers [unit.ID];

						foreach (Modifier mod in unit.Modifiers) {
							mod.ParentUnit = unit;
						}
					}
					_units.Add (unit.Name, unit);

				}
			}
		}

		void ProcessUnitTypes (XmlNode parentNode)
		{
			_unitTypes = new Dictionary<string, UnitType> ();
			foreach (XmlNode node in parentNode.ChildNodes) {
				if (node.Name == "UnitType") {
					var ut = new UnitType ();

					foreach (XmlAttribute attrib in node.Attributes) {
						switch (attrib.Name) {
						case "ID":
							ut.ID = Convert.ToInt32 (attrib.Value);
							break;
						case "Name":
							ut.Name = attrib.Value;
							break;
						case "Description":
							ut.Description = attrib.Value;
							break;
						}

					}

					// Make this a for loop for speed reasons or use a multikey dictionary.
					var unitData = (from unit in _units.Values
                                    where unit.UnitTypeID == ut.ID
                                    select unit).ToList ();
					ut.Units = unitData;

					foreach (Unit unitItem in ut.Units) {
						unitItem.UnitType = ut;
					}

					_unitTypes.Add (ut.Name, ut);

				}
			}
		}
#endif
		#endregion
		#region "UnitTypes"
		//TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        internal void GetAllUnitTypes()
        {
            if(_unitTypes == null)
            {
                this.LoadJsonDataFile();
            }
        }
		#endregion
		#region "Units"
		//TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
		Dictionary<string, Unit> GetAllUnits ()
		{
			var unitDict = new Dictionary<string, Unit> ();
			var unitPro = new UnitProvider ();
			var query = from s in unitPro.UnitTypes select s;


			foreach (var itm in query) {
				UnitType ut = itm.Value;

				foreach (var un in ut.Units) {
					if (!unitDict.ContainsKey (un.Name)) {
						unitDict.Add (un.Name, un);
					}
				}
				//Units "Celsius"
			}
			//UnitTypes "Temperature"

			return unitDict;
		}
		#endregion
		#region "Symbols"
		public Dictionary<string, Symbol> IndividualSymbols {
			get {
				if (_individualSymbols == null) {
					_individualSymbols = GetAllIndividualSymbols ();
				}
				return _individualSymbols;
			}
		}
		//TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
		Dictionary<string, Unit> GetAllSymbols ()
		{
			var unitDict = new Dictionary<string, Unit> ();
			var query = from s in this.UnitTypes select s;

			foreach (var itm in query) {
				UnitType ut = itm.Value;

				foreach (var un in ut.Units) {
					Unit unit = un;

					if (unit.Symbols == null || unit.Symbols.Count == 0) {
						//No symbols.  Add name of unit as symbol.
						if (!unitDict.ContainsKey (unit.Name)) {
							unitDict.Add (unit.Name, unit);
						}
					} else {
						foreach (var sy in unit.Symbols) {
							if (!unitDict.ContainsKey (sy.Value)) {
								unitDict.Add (sy.Value, unit);
							}
						}
						//Symbols "C"

						if (!unitDict.ContainsKey (unit.Name)) {
							unitDict.Add (unit.Name, unit);
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
		Dictionary<string, Symbol> GetAllIndividualSymbols ()
		{
			var unitDict = new Dictionary<string, Symbol> ();
			var unitPro = new UnitProvider ();
			var query = from s in unitPro.UnitTypes select s;


			foreach (var itm in query) {
				UnitType ut = itm.Value;


				foreach (var un in ut.Units) {
					Unit unit = un;

					foreach (var us in unit.Symbols) {
						if (!unitDict.ContainsKey (us.Value)) {
							unitDict.Add (us.Value, us);
						}
					}
				}
			}

			return unitDict;
		}
		#endregion
		#endregion
	}
}