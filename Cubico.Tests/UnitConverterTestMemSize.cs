using System;
using NUnit.Framework;
using Cubico;

namespace Cubico.Tests
{
    [TestFixture]
    public class UnitConverterTestMemSize
    {

        TestContext testContextInstance;
        // Gets or sets the test context which provides information about and functionality for the current test run.
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        #region "UnitConverter.ConvertUnits"
        #region "Memory Size"
        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_bit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(100);
            string currentUnitName = "bit";
            string targetUnitName = "bit";
            Measurement expected = new Measurement(Convert.ToDouble(100), "bit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_byte_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(1);
            string currentUnitName = "bit";
            string targetUnitName = "byte";
            Measurement expected = new Measurement(Convert.ToDouble(.125), "byte");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_kilobit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(1);
            string currentUnitName = "bit";
            string targetUnitName = "kilobit";
            Measurement expected = new Measurement(Convert.ToDouble(0.0009765625), "kilobit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_kilobyte_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(1);
            string currentUnitName = "bit";
            string targetUnitName = "kilobyte";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001220703125), "kilobyte");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_megabit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(1024);
            string currentUnitName = "bit";
            string targetUnitName = "megabit";
            Measurement expected = new Measurement(Convert.ToDouble(0.0009765625), "megabit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_megabyte_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(1024);
            string currentUnitName = "bit";
            string targetUnitName = "megabyte";
            Measurement expected = new Measurement(Convert.ToDouble(0.0001220703125), "megabyte");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_gigabit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(8388608);
            string currentUnitName = "bit";
            string targetUnitName = "gigabit";
            Measurement expected = new Measurement(Convert.ToDouble(0.0078125), "gigabit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_gigabyte_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(8388608);
            string currentUnitName = "bit";
            string targetUnitName = "gigabyte";
            Measurement expected = new Measurement(Convert.ToDouble(0.0009765625), "gigabyte");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_terabit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(8795755265206);
            string currentUnitName = "bit";
            string targetUnitName = "terabit";
            Measurement expected = new Measurement(Convert.ToDouble(7.999692811796), "terabit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        [Category(UnitTestCategory.Integration)]
        [Category(UnitTestCategory.UnitConversion)]
        public void UnitConverter_ConvertUnits_bit_to_petabit_Test()
        {
            UnitConverter target = new UnitConverter();
            double value = Convert.ToDouble(8795755265206);
            string currentUnitName = "bit";
            string targetUnitName = "petabit";
            Measurement expected = new Measurement(Convert.ToDouble(0.007812199979521), "petabit");
            Measurement actual = default(Measurement);
            actual = target.ConvertUnits(value, currentUnitName, targetUnitName);
            Assert.AreEqual(expected.Value, actual.Value);
        }
        #endregion
        #endregion
    }
}
