using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

namespace Units.Test
{
    public partial class UnitConverterTest
    {
        #region "UnitConverter.ConvertUnits"

        #region "Force Tests"
        #region "Source as Newton (N)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(10000000.0), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(99999.9999), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(22.4808943099999), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(0.22480894287519), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(0.011240447154986), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(0.000112404471437), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.010197162129779), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.000101971621196), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "GN");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "N";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_N_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "N";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Dyne (dyn)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(0.001), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-06), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(0.0002248089431), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2.248089429E-06), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.12404472E-07), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.124045E-09), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_ng_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.01971621E-07), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.019716E-09), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-11), "Meganewton");
            //should be 0.00000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-14), "GN");
            //should be 0.00000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-06), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-08), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(1), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(0.00999999999), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(1000), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "dyn";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(1000000), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_dyn_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "dyn";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(9999.99999), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Pound-force (lbf)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(444.82216152548), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(4.44822161080658), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(44482216.152548), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(444822.161080658), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(0.05), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(0.0004999999995), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.045359236999934), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.000453592369546), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.000444822161525), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(4.448221611E-06), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(4.44822162E-07), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(4.448222E-09), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(0.44482216152548), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(0.004448221610807), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(444822.16152548), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(4448.22161080658), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(444822161.52548), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(4448221.61080658), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lbf";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(444822161525.48), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbf_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lbf";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(4448221610.80658), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Ton-force(short) (tonf)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(889644.3230521), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(8896.44322162456), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(88964432305.21), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(889644322.162456), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(200000), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(1999.999998), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(90.718474), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.907184739092815), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.8896443230521), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.008896443221625), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000889644323052), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(8.896443222E-06), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(889.6443230521), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(8.89644322162456), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(889644323.0521), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(8896443.22162456), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(889644323052.1), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(8896443221.62456), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonf";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(889644323052100L), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonf_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonf";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(8896443221624.56), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Tonnes force(metric) (tonnef,tf)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(980665), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(9806.64999019335), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(98066500000.0), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(980664999.019335), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(220462.2621852), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2204.62261964738), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(110.231131092439), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.10231130982208), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.980665), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.009806649990193), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000980665), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(9.80664999E-06), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(980.665), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(9.80664999019335), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(980665000), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(9806649.99019335), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(980665000000.0), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(9806649990.19335), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "tonnef";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(980665000000000.0), "nN");
            //should be 98066500000000, .net conversion bug
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_tonnef_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "tonnef";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(9806649990193.35), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Meganewton (MN)"


        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(10000000000000.0), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(99999999900.0), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(22480894.3099999), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(224808.94287519), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(11240.4471549855), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(112.404471437451), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(10197.1621297793), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(101.971621195821), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000L), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999.0), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "Meganewton";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(1E+17), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_Meganewton_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "Meganewton";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000000.0), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Giganewton (GN)"


        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(1E+16), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(99999999900000.0), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(22480894309.9999), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(224808942.87519), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(11240447.154986), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(112404.471437456), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_ng_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(10197162.1297793), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(101971.621195821), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(1E+17), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000000.0), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "GN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(1E+20), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GN_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "GN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E+17), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Kilonewton (kN)"


        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(10000000000L), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(99999999.9), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(22480.8943099999), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(224.80894287519), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(11.2404471549855), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(0.112404471437451), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(10.1971621297793), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(0.101971621195821), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000.0), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000000000.0), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kN_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(999999999000.0), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Milinewton (mN)"


        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(10000), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(99.9999999), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(0.02248089431), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(0.000224808942875), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.1240447155E-05), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.12404471E-07), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.019716213E-05), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.01971621E-07), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "Meganewton");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "GN");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "mN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(100000000), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_mN_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "mN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(999999.999), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Micronewton (µN)"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(10), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(0.0999999999), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2.248089431E-05), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2.24808943E-07), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.1240447E-08), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.12404E-10), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.0197162E-08), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.01972E-10), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "Meganewton");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "GN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "GN");
            //should be 0.000000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "kN");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_nN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "µN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(100000), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_µN_to_nN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "µN";
            string targetUnitName = "nN";
            Measurement expected = new Measurement(Convert.ToDouble(999.999999), "nN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as Nananewton (nN)"


        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_N_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(1E-07), "N");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_N_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "N";
            Measurement expected = new Measurement(Convert.ToDouble(1E-09), "N");
            //should be 0.000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_dyn_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(0.01), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_dyn_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "dyn";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-05), "dyn");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_lbf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2.2480894E-08), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_lbf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "lbf";
            Measurement expected = new Measurement(Convert.ToDouble(2.24809E-10), "lbf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_tonf_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.124E-11), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_tonf_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "tonf";
            Measurement expected = new Measurement(Convert.ToDouble(1.12E-13), "tonf");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_tonnef_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.0197E-11), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_tonnef_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "tonnef";
            Measurement expected = new Measurement(Convert.ToDouble(1.02E-13), "tonnef");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_Meganewton_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-13), "Meganewton");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_Meganewton_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "Meganewton";
            Measurement expected = new Measurement(Convert.ToDouble(1E-15), "Meganewton");
            //should be 0.000000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_GN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0), "GN");
            //should be .0000000000000001, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_GN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "GN";
            Measurement expected = new Measurement(Convert.ToDouble(0), "GN");
            //should be 9.99999999E-19, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_kN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-10), "kN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_kN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "kN";
            Measurement expected = new Measurement(Convert.ToDouble(1E-12), "kN");
            //should be 0.000000000000999999999, .net rounds to 15 places
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_mN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_mN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "mN";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-07), "mN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_µN_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "nN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(0.1), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_nN_to_µN_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "nN";
            string targetUnitName = "µN";
            Measurement expected = new Measurement(Convert.ToDouble(0.000999999999), "µN");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion

        #region "Momentum Tests"
        #region "Source as kg m/s"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMetersPerSec_to_lbFtPerHr_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(2603884.98643556), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMetersPerSec_to_lbFtPerHr_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(26038.8498383168), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_GramCentimeterPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kg m/s";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(10000000), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_GramCentimeterPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kg m/s";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(99999.9999), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(43398.0831072594), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(433.980830638613), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(723.301385120989), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "kg m/s";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(7.23301384397688), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as lb ft/hr"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_kgMetersPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.003840415399333), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_kgMetersPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(3.8404153955E-05), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_GramCentimeterPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(384.041539933333), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_GramCentimeterPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(3.84041539549292), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(1.66666666666667), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.01666666665), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.027777777777778), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/hr";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.0002777777775), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as g cm/s"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_kgMetersPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "g cm/s";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.001), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_kgMetersPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "g cm/s";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(9.99999999E-06), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerHr_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(26.0388498643556), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerHr_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(0.260388498383168), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.4339808310726), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(0.004339808306386), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.0072330138512), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "g cm/s";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(7.233013844E-05), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as lb ft/min"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_kgMetersPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.23042492396), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_kgMetersPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.002304249237296), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerHr_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(6000), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerHr_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(59.99999994), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_GramCentimeterPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(23042.4923959997), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_GramCentimeterPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(230.424923729572), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(1.66666666666667), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/min";
            string targetUnitName = "lb ft/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.01666666665), "lb ft/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion

        #region "Source as lb ft/sec"

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_kgMetersPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(13.8254954376), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_kgMetersPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "kg m/s";
            Measurement expected = new Measurement(Convert.ToDouble(0.138254954237745), "kg m/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerHr_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(360000), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerHr_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "lb ft/hr";
            Measurement expected = new Measurement(Convert.ToDouble(3599.9999964), "lb ft/hr");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_GramCentimeterPerSec_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(1382549.54376189), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_GramCentimeterPerSec_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "g cm/s";
            Measurement expected = new Measurement(Convert.ToDouble(13825.4954237934), "g cm/s");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerMin_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(6000), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [TestMethod()]
        [TestCategory(UnitTestCategory.Integration)]
        [TestCategory(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerMin_Test2()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(0.999999999);
            string currentUnitName = "lb ft/s";
            string targetUnitName = "lb ft/min";
            Measurement expected = new Measurement(Convert.ToDouble(59.99999994), "lb ft/min");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        #endregion
        #endregion
        #endregion
    }
}
