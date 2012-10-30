using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

namespace Units.Test
{
    [TestClass()]
    public class UnitConverterTest3
    {
        private TestContext testContextInstance;

        private UnitProvider unitPro = new UnitProvider();
        ///<summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        #region "Additional test attributes"
        //
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //<ClassInitialize()> _  _
        //Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
        //End Sub
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //<ClassCleanup()> _  _
        //Public Shared Sub MyClassCleanup()
        //End Sub
        //
        //Use TestInitialize to run code before running each test
        //<TestInitialize()> _  _
        //Public Sub MyTestInitialize()
        //End Sub
        //
        //Use TestCleanup to run code after each test has run
        //<TestCleanup()> _  _
        //Public Sub MyTestCleanup()
        //End Sub
        //

        #endregion
        
        #region "UnitConverter.ConvertUnits"

        #region "Power Tests"
        #region "Source as Watts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(0.134102208959503), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(0.001341022088254), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000L), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_MilliWatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_MilliWatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.68690192748063), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.056869019217937), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "W";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4425.37289566359), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Watts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "W";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(44.2537289123822), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Horsepower"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(74569.987158227), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(745.69987083657), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.074569987158227), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.000745699870837), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(74.569987158227), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.74569987083657), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(74569987158.227), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(745699870.83657), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(74569987158227.0), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(745699870836.57), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_MilliWatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(74569987.158227), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_MilliWatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(745699.870836571), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(4240.72203702327), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(42.4072203278255), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "hp";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(3300000), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Horsepower_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "hp";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(32999.999967), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Megawatts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(134102.208959503), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1341.02208825401), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000L), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000L), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000000L), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000000L), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_MilliWatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000L), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_MilliWatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5686901.92748063), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(56869.0192179373), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "MW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4425372895.66359), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megawatts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "MW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(44253728.9123822), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Kilowatts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(134.102208959503), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.34102208825401), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000L), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000L), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000L), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_MilliWatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_MilliWatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5686.90192748063), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(56.8690192179373), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4425372.89566359), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Kilowatts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(44253.7289123822), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Microwatts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.34102209E-07), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.341022E-09), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "MW");
            //should be 0.000000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_kikowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "kW");
            //should be 0.000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Milliwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_Milliwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.686901927E-06), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.6869019E-08), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.004425372895664), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Microwatts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4.4253728912E-05), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Nanowatts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "W");
            //should be 0.000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.34102E-10), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.341E-12), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "MW");
            //should be 0.000000000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "kW");
            //should be 0.000000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Milliwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_Milliwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.686902E-09), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.6869E-11), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4.425372896E-06), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Nanowatts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4.4253729E-08), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Milliwatts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(0.00013410220896), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(1.341022088E-06), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "MW");
            //should be 0.000000000999999999, can only round to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.005686901927481), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(5.6869019218E-05), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(4.42537289566359), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Milliwatts_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mW";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.044253728912382), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as BTU/min"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(1758.42666666667), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(17.5842666490824), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(2.35808900293295), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(0.023580890005749), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(0.001758426666667), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(1.7584266649E-05), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(1.75842666666667), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.017584266649082), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(1758426666.66667), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(17584266.6490824), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(1758426666666.67), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(17584266649.0824), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Milliwatts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(1758426.66666667), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_Milliwatts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(17584.2666490824), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_FtLbPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "BTU/min";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(77816.9370967875), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_BTUperMin_to_FtLbPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "BTU/min";
            string targetUnitName = "ft lb/min";
            Measurement expected = new Measurement(Convert.ToDouble(778.169370189705), "ft lb/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as ft lb/min"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Watts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(2.25969658055233), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Watts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "W";
            Measurement expected = new Measurement(Convert.ToDouble(0.022596965782926), "W");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Horsepower_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(0.003030303030303), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Horsepower_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "hp";
            Measurement expected = new Measurement(Convert.ToDouble(3.0303030273E-05), "hp");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Megawatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(2.259696581E-06), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Megawatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "MW";
            Measurement expected = new Measurement(Convert.ToDouble(2.2596966E-08), "MW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Kilowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(0.002259696580552), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Kilowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "kW";
            Measurement expected = new Measurement(Convert.ToDouble(2.2596965783E-05), "kW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Microwatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(2259696.58055233), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Microwatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "µW";
            Measurement expected = new Measurement(Convert.ToDouble(22596.9657829264), "µW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Nanowatt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(2259696580.55233), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Nanowatt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "nW";
            Measurement expected = new Measurement(Convert.ToDouble(22596965.7829264), "nW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Milliwatts_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(2259.69658055233), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_Milliwatts_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "mW";
            Measurement expected = new Measurement(Convert.ToDouble(22.5969657829264), "mW");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_BTUperMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.128506728394644), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_FtLbPerMin_to_BTUperMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft lb/min";
            string targetUnitName = "BTU/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.001285067282661), "BTU/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion

        #region "Energy Tests"
        #region "Source as Joule"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1000000000), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9999999.99), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(23.8845896627496), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(0.23884589638865), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(0.094781712031332), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(0.000947817119366), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.47816988E-07), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.47817E-09), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "GJ");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "J";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_J_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "J";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Energy (erg)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(1E-05), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.388458966E-06), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.388459E-08), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.478171E-09), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.4782E-11), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.5E-14), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "therm");
            //should be 0.000000000000000947816987, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.01), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-05), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-11), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "Megajoule");
            //should be 0.0000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-08), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "kJ");
            //should be 0.000000000099999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-14), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0), "GJ");
            //should be 9.99999999E-17, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(10), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.0999999999), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "erg";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(10000), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_erg_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "erg";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(99.9999999), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Calorie (cal)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(418.68), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(4.1867999958132), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(4186800000L), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(41867999.958132), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(0.396832071932955), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(0.003968320715361), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(3.968320165E-06), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(3.9683202E-08), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(418680), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(4186.7999958132), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.00041868), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(4.186799996E-06), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.41868), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.004186799995813), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(4.1868E-07), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(4.1868E-09), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(418680000), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(4186799.9958132), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cal";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(418680000000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cal_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cal";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(4186799995.8132), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as British thermal unit (Btu)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(105505.585262), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(1055.05585156494), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1055055852620.0), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(10550558515.6494), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(25199.5761111), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(251.995760859004), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(0.001), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-06), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505585.262), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(1055055.85156494), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.105505585262), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.001055055851565), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(105.505585262), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1.05505585156494), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.000105505585262), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1.055055852E-06), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505585262.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(1055055851.56494), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Btu";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505585262000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Btu_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Btu";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(1055055851564.94), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Therm (therm)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(10550560000.0), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(105505599.894494), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1.055056E+17), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1055055998944944L), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2519957963.1222), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(25199579.6060224), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(10000000), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(99999.9999), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(10550560000000.0), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505599894.494), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(10550.56), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(105.505599894494), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(10550560), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505.599894494), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(10.55056), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.105505599894494), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(1.055056E+16), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(105505599894494.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "therm";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(1.055056E+19), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_therm_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "therm";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(1.05505599894494E+17), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Millijoules (mJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "J");
            //actual value 0.001, .net bug
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1000000), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9999.99999), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(0.02388458966275), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(0.000238845896389), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.4781712031E-05), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.47817119E-07), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.47817E-10), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.478E-12), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "Megajoule");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "GJ");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mJ_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Megajoules (MJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1E+15), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9999999990000.0), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(23884589.6627496), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(238845.89638865), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(94781.7120313317), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(947.8171193655), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(0.947816987913438), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(0.009478169869656), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Megajoule";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E+17), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Megajoule_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Megajoule";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Kilojoules (kJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1000000000000.0), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9999999990L), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(23884.5896627496), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(238.84589638865), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(94.7817120313317), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(0.9478171193655), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(0.000947816987913), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.47816987E-06), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kJ_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Gigajoules (GJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1E+18), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E+15), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(23884589662.75), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(238845896.388654), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(94781712.031332), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(947817.119365503), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(947.816987913438), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.47816986965621), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E+17), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000000.0), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E+20), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GJ_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E+17), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Microjoules (µJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1000), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.3884589663E-05), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.38845896E-07), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.4781712E-08), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.47817E-10), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9.48E-13), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(9E-15), "therm");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "Megajoule");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "kJ");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "GJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "GJ");
            //should be 0.000000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_nJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µJ_to_nJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µJ";
            string targetUnitName = "nJ";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "nJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion

        #region "Source as Nanojoules (nJ)"
        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_J_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "J");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_J_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "J";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "J");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_erg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(1), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_erg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "erg";
            Measurement expected = new Measurement(Convert.ToDouble(0.00999999999), "erg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_cal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.388459E-08), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_cal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "cal";
            Measurement expected = new Measurement(Convert.ToDouble(2.38846E-10), "cal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_Btu_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.4782E-11), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_Btu_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "Btu";
            Measurement expected = new Measurement(Convert.ToDouble(9.48E-13), "Btu");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_therm_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "therm");
            //should be 0.0000000000000009478169879, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_therm_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "therm";
            Measurement expected = new Measurement(Convert.ToDouble(0), "therm");
            //should be 9.47816987E-18, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_mJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_mJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "mJ";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "mJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_Megajoule_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "Megajoule");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_Megajoule_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "Megajoule";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "Megajoule");
            //should be 0.000000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_kJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "kJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_kJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "kJ";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "kJ");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_GJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0), "GJ");
            //should be 0.0000000000000001, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_GJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "GJ";
            Measurement expected = new Measurement(Convert.ToDouble(0), "GJ");
            //should be 9.99999999E-19, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_µJ_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nJ_to_µJ_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nJ";
            string targetUnitName = "µJ";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "µJ");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion
        #endregion

        #region "Plane Angle Tests"

        #region "Source as Radians"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_deg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rad";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(5729.57795130823), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_deg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rad";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(57.2957794557866), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_grad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rad";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(6366.19772367581), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_grad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rad";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(63.6619771730962), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_rev_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rad";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(15.915494309), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rad_to_rev_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rad";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(0.159154942930845), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Degrees"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_rad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "deg";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(1.74532925199433), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_rad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "deg";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(0.01745329250249), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_grad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "deg";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(111.111111111111), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_grad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "deg";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(1.11111111), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_rev_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "deg";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(0.277777777777778), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_deg_to_rev_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "deg";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(0.002777777775), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Gradians"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_rad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "grad";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(1.5707963267949), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_rad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "grad";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(0.015707963252241), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_deg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "grad";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(90), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_deg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "grad";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(0.8999999991), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_rev_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "grad";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(0.25), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_grad_to_rev_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "grad";
            string targetUnitName = "rev";
            Measurement expected = new Measurement(Convert.ToDouble(0.0024999999975), "rev");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Revolutions"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_rad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rev";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(628.318530725441), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_rad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rev";
            string targetUnitName = "rad";
            Measurement expected = new Measurement(Convert.ToDouble(6.28318530097123), "rad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_deg_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rev";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(36000), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_deg_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rev";
            string targetUnitName = "deg";
            Measurement expected = new Measurement(Convert.ToDouble(359.99999964), "deg");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_grad_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "rev";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(40000), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_rev_to_grad_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "rev";
            string targetUnitName = "grad";
            Measurement expected = new Measurement(Convert.ToDouble(399.9999996), "grad");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #endregion

        #region "Volume Tests"
        #region "Source as Cubic Inches"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.05787037037037), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000578703703125), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.002143347050754), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(2.1433470486E-05), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.0016387064), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(1.6387063984E-05), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(1638.7064), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(16.387063983613), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(1.6387064), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.016387063983613), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(55.4112554112554), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(0.554112553558442), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.432900432900433), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.004329004324675), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(3.46320346320346), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(0.034632034597403), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(1.73160173160173), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in3_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(0.017316017298701), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Cubic Feet"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(172800), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(1727.999998272), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(3.7037037037037), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.037037037), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(2.8316846592), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.028316846563683), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(2831684.6592), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(28316.8465636832), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(2831.6846592), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(28.3168465636832), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(95750.6493506493), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(957.506492548987), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(748.051948051948), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(7.48051947303896), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(5984.41558441558), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(59.8441557843117), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(2992.20779220779), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft3_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(29.9220778921558), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Cubic Yards"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(4665600), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(46655.999953344), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(2700), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(26.999999973), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(76.4554857984), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.764554857219445), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(76455485.7984), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(764554.857219445), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(76455.4857984), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(764.554857219445), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(2585267.53246753), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(25852.6752988226), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(20197.4025974026), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(201.974025772052), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(161579.220779221), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(1615.79220617642), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(80789.6103896104), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd3_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(807.896103088208), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Cubic Meters"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(6102374.40947323), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(61023.7440337085), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(3531.46667214886), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(35.3146666861739), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(130.795061931439), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(1.30795061800644), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(3381402.2701843), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(33814.022668029), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(26417.2052358148), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(264.172052093976), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(211337.641886519), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(2113.37641675181), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(105668.820943259), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m3_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m3";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(1056.68820837591), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Cubic Centimeters"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(6.10237440947323), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(0.061023744033709), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.003531466672149), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(3.5314666686E-05), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000130795061931), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(1.307950618E-06), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(3.3814022701843), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(0.033814022668029), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.026417205235815), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.000264172052094), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(0.211337641886519), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(0.002113376416752), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cc";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(0.105668820943259), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cc_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cc";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(0.001056688208376), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Liters"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(6102.37440947323), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(61.0237440337085), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(3.53146667214886), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.035314666686174), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.130795061931439), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.001307950618006), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(3381.4022701843), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(33.814022668029), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(26.4172052358148), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.264172052093976), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(211.337641886519), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(2.11337641675181), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "L";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(105.668820943259), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_L_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "L";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(1.05668820837591), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Fluid Ounces"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(180.46875), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(1.80468749819531), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.104437934027778), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.001044379339233), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.003868071630658), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(3.8680716268E-05), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.00295735295625), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(2.9573529533E-05), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(2957.35295625), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(29.5735295329265), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(2.95735295625), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.029573529532926), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.78125), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.007812499992188), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(6.25), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(0.0624999999375), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "fl oz";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(3.125), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_floz_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "fl oz";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(0.03124999996875), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Gallons"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(23100), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(230.999999769), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(13.3680555555556), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.133680555421875), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.49511316872428), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.004951131682292), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.3785411784), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.003785411780215), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(378541.1784), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(3785.41178021459), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(378.5411784), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(3.78541178021459), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(12800), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(127.999999872), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(800), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(7.999999992), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "gal";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(400), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_gal_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "gal";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(3.999999996), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Pints"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(2887.5), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(28.874999971125), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(1.67100694444444), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.016710069427734), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.061889146090535), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000618891460286), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.0473176473), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000473176472527), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(47317.6473), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(473.176472526824), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(47.3176473), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.473176472526824), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(1600), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(15.999999984), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(12.5), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.124999999875), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_qt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "pt";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(50), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_pt_to_qt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "pt";
            string targetUnitName = "qt";
            Measurement expected = new Measurement(Convert.ToDouble(0.4999999995), "qt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Quarts"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_in3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(5775), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_in3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "in3";
            Measurement expected = new Measurement(Convert.ToDouble(57.74999994225), "in3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_ft3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(3.34201388888889), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_ft3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "ft3";
            Measurement expected = new Measurement(Convert.ToDouble(0.033420138855469), "ft3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_yd3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.12377829218107), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_yd3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "yd3";
            Measurement expected = new Measurement(Convert.ToDouble(0.001237782920573), "yd3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_m3_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.0946352946), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_m3_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "m3";
            Measurement expected = new Measurement(Convert.ToDouble(0.000946352945054), "m3");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_cc_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(94635.2946), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_cc_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "cc";
            Measurement expected = new Measurement(Convert.ToDouble(946.352945053647), "cc");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_L_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(94.6352946), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_L_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "L";
            Measurement expected = new Measurement(Convert.ToDouble(0.946352945053647), "L");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_floz_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(3200), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_floz_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "fl oz";
            Measurement expected = new Measurement(Convert.ToDouble(31.999999968), "fl oz");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_gal_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(25), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_gal_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "gal";
            Measurement expected = new Measurement(Convert.ToDouble(0.24999999975), "gal");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_pt_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "qt";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(200), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_qt_to_pt_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "qt";
            string targetUnitName = "pt";
            Measurement expected = new Measurement(Convert.ToDouble(1.999999998), "pt");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion
        #endregion
    }
}
