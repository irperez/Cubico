using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace Units
{
    /// <summary>
    /// Facilitates the loading and caching of the unit of measure data.
    /// </summary>
    public class UnitProvider
    {

        #region "Constructors"
        public UnitProvider()
        {
            if (_dataFile == null)
            {
                this.LoadDataFile();
            }
        }
        #endregion

        #region "Properties"
        static private XmlDocument _dataFile;
        protected XmlDocument DataFile 
        { 
            get{return _dataFile;}
            set{ _dataFile = value;}
        }

        //Singleton
        private static Dictionary<string, UnitType> _unitTypes;
        public Dictionary<string, UnitType> UnitTypes
        {
            get
            {
                if (_unitTypes == null)
                {
                    GetAllUnitTypes();
                }
                return _unitTypes;
            }
        }

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

        private static Dictionary<int, List<Modifier>> _individualModifiers;
        private static Dictionary<string, Unit> _symbols;

        private static Dictionary<string, Symbol> _individualSymbols;
        private static Dictionary<int, List<Symbol>> _symbolLookUp;
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
        #endregion

        #region "Methods"
        #region "File Load Methods"

        private void LoadDataFile()
        {
            const string fileName = "Units.UnitData.xml";
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(fileName);

            if (stream == null)
            {
                throw new FileNotFoundException("Cannot find unit data file", fileName);
            }

            _dataFile = new XmlDocument();
            _dataFile.Load(stream);

            this.ProcessUnitConverterData();
        }

        private void ProcessUnitConverterData()
        {
            foreach (XmlNode node in this.DataFile.ChildNodes)
            {
                if (node.Name == "UnitConverterData")
                {
                        ProcessDataTypes(node);   
                }
            }
        }

        private void ProcessDataTypes(XmlNode parentNode)
        {
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                switch (node.Name)
                {
                    case "UnitTypes":
                        ProcessUnitTypes(node);
                        break;
                    case "Units":
                        ProcessUnits(node);
                        break;
                    case "Symbols":
                        ProcessUnitSymbols(node);
                        break;
                    case "UnitModifiers":
                        ProcessUnitModifiers(node);
                        break;
                }
            }
        }

        private void ProcessUnitModifiers(XmlNode parentNode)
        {
            _individualModifiers = new Dictionary<int, List<Modifier>>();

            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if (node.Name == "UnitModifier")
                {
                    var mod = new Modifier();

                    foreach (XmlAttribute attrib in node.Attributes)
                    {
                        switch (attrib.Name)
                        {
                            case "ID":
                                mod.ID = Convert.ToInt32(attrib.Value);
                                break;
                            case "Value":
                                mod.Value = Convert.ToDecimal(attrib.Value);
                                break;
                            case "Order":
                                mod.Order = Convert.ToInt32(attrib.Value);
                                break;
                            case "ModifierID":
                                mod.ModifierType = (ModifierType)Convert.ToInt32(attrib.Value);
                                break;
                            case "UnitSourceID":
                                mod.UnitSourceID = Convert.ToInt32(attrib.Value);
                                break;
                            case "UnitTargetID":
                                mod.UnitTargetID = Convert.ToInt32(attrib.Value);
                                break;
                            case "Precision":
                                mod.Precision = Convert.ToInt32(attrib.Value);
                                break;
                        }

                    }

                    if (_individualModifiers.ContainsKey(mod.UnitSourceID))
                    {
                        var data = _individualModifiers[mod.UnitSourceID];
                        data.Add(mod);
                    }
                    else
                    {
                        var data = new List<Modifier> {mod};
                        _individualModifiers.Add(mod.UnitSourceID, data);
                    }

                }
            }
        }

        private  void ProcessUnitSymbols(XmlNode parentNode)
        {
            _symbolLookUp = new Dictionary<int, List<Symbol>>();
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if (node.Name == "UnitSymbol")
                {
                    var sym = new Units.Symbol();

                    foreach (XmlAttribute attrib in node.Attributes)
                    {
                        switch (attrib.Name)
                        {
                            case "ID":
                                sym.ID = Convert.ToInt32(attrib.Value);
                                break;
                            case "Symbol":
                                sym.Value = attrib.Value;
                                break;
                            case "UnitID":
                                sym.UnitId = Convert.ToInt32(attrib.Value);
                                break;
                            case "IsDefault":
                                int value = Convert.ToInt32(attrib.Value);
                                if (value == 1)
                                    sym.IsDefault = true;
                                else
                                    sym.IsDefault = false;
                             
                                break;
                        }

                    }

                    if (_symbolLookUp.ContainsKey(sym.UnitId))
                    {
                        var data = _symbolLookUp[sym.UnitId];
                        data.Add(sym);
                    }
                    else
                    {
                        var data = new List<Symbol> {sym};
                        _symbolLookUp.Add(sym.UnitId, data);
                    }
                }
            }
        }

        private void ProcessUnits(XmlNode parentNode)
        {
            _units = new Dictionary<string, Unit>();
            foreach (XmlNode node in parentNode.ChildNodes)
            {
               
                if (node.Name == "Unit")
                {
                    var unit = new Unit();

                    foreach (XmlAttribute attrib in node.Attributes)
                    {
                        switch (attrib.Name)
                        {
                            case "ID":
                                unit.ID = Convert.ToInt32(attrib.Value);
                                break;
                            case "Name":
                                unit.Name = attrib.Value;
                                break;
                            case "UnitTypeID":
                                unit.UnitTypeID = Convert.ToInt32(attrib.Value);
                                break;
                        }

                    }

                    if (_symbolLookUp.ContainsKey(unit.ID))
                    {
                        unit.Symbols = _symbolLookUp[unit.ID];
                    }
                    if (_individualModifiers.ContainsKey(unit.ID))
                    {
                        unit.Modifiers = _individualModifiers[unit.ID];
                    }
                    _units.Add(unit.Name, unit);

                }
            }
        }

        private void ProcessUnitTypes(XmlNode parentNode)
        {
            _unitTypes = new Dictionary<string, UnitType>();
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if(node.Name == "UnitType")
                {
                    var ut = new UnitType();
                    
                    foreach (XmlAttribute attrib in node.Attributes)
                    {
                        switch (attrib.Name)
                        {
                            case "ID":
                                ut.ID = Convert.ToInt32(attrib.Value);
                                break;
                            case "Name":
                                ut.Name = attrib.Value;
                                break;
                            case "Description":
                                ut.Description = attrib.Value;
                                break;
                        }
                        
                    }

                    //Make this a for loop for speed reasons or use a multikey dictionary.
                    var unitData = (from unit in _units.Values
                                    where unit.UnitTypeID == ut.ID
                                    select unit).ToList();
                    ut.Units = unitData;
                    _unitTypes.Add(ut.Name, ut);

                }
            }
        }
        #endregion

        #region "UnitTypes"
        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private void GetAllUnitTypes()
        {

            
        }
        #endregion

        #region "Units"
        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private Dictionary<string, Unit> GetAllUnits()
        {
            var unitDict = new Dictionary<string, Unit>();
            var unitPro = new UnitProvider();
            var query = from s in unitPro.UnitTypes select s;


            foreach (var itm in query)
            {
                UnitType ut = itm.Value;

                foreach (var un in ut.Units)
                {
                    if (!unitDict.ContainsKey(un.Name))
                    {
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
            var unitDict = new Dictionary<string, Unit>();
            var query = from s in this.UnitTypes select s;

            foreach (var itm in query)
            {
                UnitType ut = itm.Value;

                foreach (var un in ut.Units)
                {
                    Unit unit = un;

                    if (unit.Symbols == null || unit.Symbols.Count == 0)
                    {
                        //No symbols.  Add name of unit as symbol.
                        if (!unitDict.ContainsKey(unit.Name))
                        {
                            unitDict.Add(unit.Name, unit);
                        }
                    }
                    else
                    {
                        foreach (var sy in unit.Symbols)
                        {
                            if (!unitDict.ContainsKey(sy.Value))
                            {
                                unitDict.Add(sy.Value, unit);
                            }
                        }
                        //Symbols "C"

                        if (!unitDict.ContainsKey(unit.Name))
                        {
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
            var unitDict = new Dictionary<string, Symbol>();
            var unitPro = new UnitProvider();

            var query = from s in unitPro.UnitTypes select s;


            foreach (var itm in query)
            {
                UnitType ut = itm.Value;


                foreach (var un in ut.Units)
                {
                    Unit unit = un;

                    foreach (var us in unit.Symbols)
                    {
                        if (!unitDict.ContainsKey(us.Value))
                        {
                            unitDict.Add(us.Value, us);
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