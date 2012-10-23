using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;

namespace Units
{
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
                    GetAllUnitTypes();
                }
                return _unitTypes;
            }
        }

        private void LoadDataFile()
        {
            string fileName = "Units.UnitData.xml";
            Assembly assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(fileName);

            if (stream == null)
            {
                throw new FileNotFoundException("Cannot find unit data file", fileName);
            }

            _dataFile = new XmlDocument();
            _dataFile.Load(stream);

            this.GetAllUnitTypes();
        }

        //TODO: Change to ReadOnlyDictionary when .Net 4.0 is available
        private void GetAllUnitTypes()
        {
            _unitTypes = new Dictionary<string, UnitType>();

            ProcessUnitConverterData();
        }

        private void ProcessUnitConverterData()
        {
            foreach (XmlNode node in this.DataFile.ChildNodes)
            {
                switch (node.Name)
                {
                    case "UnitConverterData":
                        ProcessDataTypes(node);
                        break;
                    case "test 2":
                        int j = 0;
                        j++;
                        break;
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
                }
            }
        } 

        private void ProcessUnitTypes(XmlNode parentNode)
        {
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                if(node.Name == "UnitType")
                {
                    UnitType ut = new UnitType();
                    
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

                    _unitTypes.Add(ut.Name, ut);

                }
            }
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

            var query = from s in unitPro.UnitTypes select s;


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
            Dictionary<string, Symbol> unitDict = new Dictionary<string, Symbol>();
            UnitProvider unitPro = new UnitProvider();

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

    }
}