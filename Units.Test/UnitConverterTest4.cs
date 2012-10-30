using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

namespace Units.Test
{
    [TestClass()]
    class UnitConverterTest4
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

        #region "Area Tests"
        #region "Source as Square Meters"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(1076.39104167097), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(10.7639104059458), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.8610215854E-05), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.86102158E-07), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(0.024710538146717), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(0.00024710538122), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(155000.31000062), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(1550.0030984562), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(1000000), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(9999.99999), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(119.599004630108), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(1.19599004510509), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "m2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(0.01), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_m2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "m2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-05), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Feet"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(9.290304), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(0.092903039907097), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.587006428E-06), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.5870064E-08), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(0.002295684113866), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(2.2956841116E-05), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(14400), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(143.999999856), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(92903.04), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(929.03039907097), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(11.1111111111111), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(0.111111111), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(9.290304E-06), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(9.290304E-08), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ft2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(0.0009290304), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ft2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ft2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(9.290303991E-06), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Miles"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(258998811.0336), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(2589988.10774601), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(2787840000L), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(27878399.9721216), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(64000), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(639.99999936), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(401448960000L), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(4014489595.98551), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(2589988110336L), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(25899881077.46), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(309760000), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(3097599.9969024), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(258.9988110336), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(2.589988107746), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mi2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(25899.88110336), "ha");
            //should be 25899.88110336, .net conversion bug
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mi2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mi2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(258.998810774601), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Acres"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(404685.64224), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(4046.85641835314), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(4356000), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(43559.99995644), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(0.15625), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(0.001562499998438), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(627264000), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(6272639.99372736), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(4046856422.4), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(40468564.1835314), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(484000), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(4839.99999516), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(0.40468564224), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(0.004046856418353), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "acre";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(40.468564224), "ha");
            //should be 40.468564224, .net conversion bug 
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_acre_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "acre";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(0.404685641835314), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Inches"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(0.064516), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(0.000645159999355), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(0.694444444444444), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(0.0069444444375), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(2.4909767E-08), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(2.49098E-10), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(1.5942250791E-05), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(1.59422508E-07), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(645.16), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(6.4515999935484), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(0.07716049382716), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(0.0007716049375), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(6.4516E-08), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(6.4516E-10), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "in2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(6.4516E-06), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_in2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "in2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(6.4516E-08), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Centimeters"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(0.107639104167097), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(0.001076391040595), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.861022E-09), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.861E-11), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(2.471053815E-06), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(2.4710538E-08), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(15.500031000062), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(0.15500030984562), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(0.01), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-05), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(0.011959900463011), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(0.000119599004511), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(1E-08), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cm2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(1E-06), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cm2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cm2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(1E-08), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Yards"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(83.612736), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(0.836127359163873), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(900), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(8.999999991), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.2283057851E-05), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(3.22830578E-07), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(0.020661157024793), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(0.000206611570041), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(129600), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(1295.999998704), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(836127.36), "cm2");
            //should be 836127.36, .net conversion bug
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(8361.27359163873), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(8.3612736E-05), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(8.36127359E-07), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "yd2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(0.0083612736), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_yd2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "yd2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(8.3612735916E-05), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Square Kilometers"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(1076391041.67097), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(10763910.4059458), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(38.6102158542446), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(0.386102158156344), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(24710.5381467165), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(247.10538122006), "acre");
            //should be 247.10538122006, .net conversion bug
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(155000310000.62), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(1550003098.4562), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(1000000000000L), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(9999999990L), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(119599004.630108), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(1195990.04510509), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_ha_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "km2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(10000), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_km2_to_ha_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "km2";
            string targetUnitName = "ha";
            Measurement expected = new Measurement(Convert.ToDouble(99.9999999), "ha");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Hectares"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_m2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(1000000.0), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_m2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "m2";
            Measurement expected = new Measurement(Convert.ToDouble(9999.99999), "m2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_ft2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(10763910.4167097), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_ft2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "ft2";
            Measurement expected = new Measurement(Convert.ToDouble(107639.104059458), "ft2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_mi2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(0.386102158542446), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_mi2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "mi2";
            Measurement expected = new Measurement(Convert.ToDouble(0.003861021581563), "mi2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_acre_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(247.105381467165), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_acre_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "acre";
            Measurement expected = new Measurement(Convert.ToDouble(2.4710538122006), "acre");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_in2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(1550003100.0062), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_in2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "in2";
            Measurement expected = new Measurement(Convert.ToDouble(15500030.984562), "in2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_cm2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(10000000000L), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_cm2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "cm2";
            Measurement expected = new Measurement(Convert.ToDouble(99999999.9), "cm2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_yd2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(1195990.04630108), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_yd2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "yd2";
            Measurement expected = new Measurement(Convert.ToDouble(11959.9004510509), "yd2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_km2_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "ha";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(1), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_ha_to_km2_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "ha";
            string targetUnitName = "km2";
            Measurement expected = new Measurement(Convert.ToDouble(0.00999999999), "km2");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion

        #region "Absorbed Radiation Dose Tests"
        #region "Source as Gray"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_cGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Gy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(10000), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_cGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Gy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(99.9999999), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_mGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Gy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_mGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Gy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_µGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Gy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_µGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Gy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_kGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Gy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Gy_to_kGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Gy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Centigray"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_Gy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(1), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_Gy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(0.00999999999), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_mGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(1000), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_mGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_µGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(1000000), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_µGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(9999.99999), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_kGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "cGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.001), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_cGy_to_kGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "cGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-06), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Milligray"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_Gy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_Gy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_cGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(10), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_cGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.0999999999), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_µGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_µGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_kGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mGy_to_kGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Microgray"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_Gy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_Gy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_cGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.01), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_cGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-05), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_mGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_mGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_kGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µGy_to_kGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µGy";
            string targetUnitName = "kGy";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "kGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Kilogray"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_Gy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_Gy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kGy";
            string targetUnitName = "Gy";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "Gy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_cGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(10000000), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_cGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kGy";
            string targetUnitName = "cGy";
            Measurement expected = new Measurement(Convert.ToDouble(99999.9999), "cGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_mGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_mGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kGy";
            string targetUnitName = "mGy";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "mGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_µGy_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000L), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kGy_to_µGy_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kGy";
            string targetUnitName = "µGy";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "µGy");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion

        #endregion

        #region "UnitConverter.UnitConverter()"
        ///<summary>
        ///A test for UnitConverter Constructor
        ///</summary>
        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverterConstructorTest()
        {
            UnitConverter target = new UnitConverter();
            Assert.IsNotNull(target);
        }
        #endregion

        #region "Empty and Null Tests"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsNullTest()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, null, null);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsNullTest2()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, "ft", null);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsNullTest3()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, null, "m");
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsEmptyTest()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, string.Empty, string.Empty);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsEmptyTest2()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, "ft", string.Empty);
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Unit)]
        public void UnitConverter_ConvertUnitsEmptyTest3()
        {
            UnitConverter target = new UnitConverter();
            Measurement expected = new Measurement(0, Result.BadUnit);
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(0, string.Empty, "m");
            Assert.AreNotEqual(expected, actual);
            Assert.AreEqual(expected.ConversionResult, actual.ConversionResult);
        }

        #endregion
    }
}
