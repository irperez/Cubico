using System;
using NUnit.Framework;
using Cubico;

namespace Cubico.Tests
{
	///This is a test class for UnitConverterTest and is intended to contain all UnitConverterTest Unit Tests
	[TestFixture]
	public class UnitConverterTest
	{
		private TestContext testContextInstance;
		private UnitProvider unitPro = new UnitProvider ();
		///<summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext {
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

		#region "UnitConverter.ParseUnitString"
		///<summary>
		///A test for ParseUnitString
		///</summary>
		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10ft";
			Measurement expected = new Measurement (10, "ft");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest2 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10 ft";
			Measurement expected = new Measurement (10, "ft");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest3 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10 m/s";
			Measurement expected = new Measurement (10, "m/s");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest4 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10'";
			Measurement expected = new Measurement (10, "'");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest5 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10ft²";
			Measurement expected = new Measurement (10, "ft²");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest6 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10˚";
			Measurement expected = new Measurement (10, "˚");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest7 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10 ˚F";
			Measurement expected = new Measurement (10, "˚F");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest8 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10 µK";
			Measurement expected = new Measurement (10, "µK");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringTest9 ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "-10 µK";
			Measurement expected = new Measurement (-10, "µK");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringNotFoundTest ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10 ZZZZ";
			Measurement expected = new Measurement (0, Result.BadUnit);
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);

			Assert.AreNotEqual<Measurement> (expected, actual);
			Assert.AreEqual (expected.ConversionResult, actual.ConversionResult);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringNoSymbolTest ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "10";
			Measurement expected = new Measurement (0, Result.BadUnit);
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);

			Assert.AreNotEqual<Measurement> (expected, actual);
			Assert.AreEqual (expected.ConversionResult, actual.ConversionResult);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringNoValueTest ()
		{
			UnitConverter target = new UnitConverter ();
			string input = "ft";
			Measurement expected = new Measurement (0, "ft");
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (input);
			Assert.AreEqual<Measurement> (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringNullTest ()
		{
			UnitConverter target = new UnitConverter ();
			Measurement expected = new Measurement (0, Result.BadValue);
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (null);
			Assert.AreNotEqual<Measurement> (expected, actual);
			Assert.AreEqual (expected.ConversionResult, actual.ConversionResult);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		public void UnitConverter_ParseUnitStringEmptyTest ()
		{
			UnitConverter target = new UnitConverter ();
			Measurement expected = new Measurement (0, Result.BadValue);
			Measurement actual = default(Measurement);
			actual = target.ParseUnitString (string.Empty);
			Assert.AreNotEqual<Measurement> (expected, actual);
			Assert.AreEqual (expected.ConversionResult, actual.ConversionResult);
		}
		#endregion

		#region "UnitConverter.IsCompatible"
		///<summary>
		///A test for IsCompatible
		///</summary>
		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		public void UnitConverter_IsCompatibleTest ()
		{
			UnitConverter target = new UnitConverter ();
			string leftSymbol = "C";
			string rightSymbol = "F";
			bool actual = false;
			actual = target.IsCompatible (leftSymbol, rightSymbol);
			Assert.IsTrue (actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		public void UnitConverter_IsCompatibleFalseTest ()
		{
			UnitConverter target = new UnitConverter ();
			string leftSymbol = "C";
			string rightSymbol = "in";
			bool actual = false;
			actual = target.IsCompatible (leftSymbol, rightSymbol);
			Assert.IsFalse (actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleNullTest ()
		{
			UnitConverter target = new UnitConverter ();
			bool actual = false;
			actual = target.IsCompatible (null, null);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleLeftNullTest ()
		{
			UnitConverter target = new UnitConverter ();
			string rightSymbol = "in";
			bool actual = false;
			actual = target.IsCompatible (null, rightSymbol);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleRightNullTest ()
		{
			UnitConverter target = new UnitConverter ();
			string leftSymbol = "C";
			bool actual = false;
			actual = target.IsCompatible (leftSymbol, null);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleEmptyTest ()
		{
			UnitConverter target = new UnitConverter ();
			bool actual = false;
			actual = target.IsCompatible (string.Empty, string.Empty);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleLeftEmptyTest ()
		{
			UnitConverter target = new UnitConverter ();
			string rightSymbol = "in";
			bool actual = false;
			actual = target.IsCompatible (string.Empty, rightSymbol);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.Unit)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_IsCompatibleRightEmptyTest ()
		{
			UnitConverter target = new UnitConverter ();
			string leftSymbol = "C";
			bool actual = false;
			actual = target.IsCompatible (leftSymbol, string.Empty);

			Assert.Fail ();
		}
		#endregion

		#region "UnitProvider.GetUnitBySymbol"
		///<summary>
		///A test for GetUnitBySymbol
		///</summary>
		[Test]
		[TestCategory(UnitTestCategory.CRUD)]
		public void UnitConverter_GetUnitBySymbol_Test ()
		{
			UnitConverter target = new UnitConverter ();
			string unitSymbol = "C";
			Unit expected = unitPro.Symbols ["C"];
			Unit actual = default(Unit);
			actual = target.GetUnitBySymbol (unitSymbol);
			Assert.AreEqual (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentNullException))]
		public void UnitConverter_GetUnitBySymbolNull_Test ()
		{
			UnitConverter target = new UnitConverter ();
			Unit actual = default(Unit);
			actual = target.GetUnitBySymbol (null);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentNullException))]
		public void UnitConverter_GetUnitBySymbolEmpty_Test ()
		{
			UnitConverter target = new UnitConverter ();
			Unit actual = default(Unit);
			actual = target.GetUnitBySymbol (string.Empty);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_GetUnitBySymbol_UnrecognizedSymbol_Test ()
		{
			UnitConverter target = new UnitConverter ();
			string unitName = "BogusUnitSymbol";
			Unit actual = default(Unit);
			actual = target.GetUnitByName (unitName);
			Assert.Fail ();
		}
		#endregion

		#region "UnitConverter.GetUnitByName"
		///<summary>
		///A test for GetUnitByName
		///</summary>
		[Test]
		[TestCategory(UnitTestCategory.CRUD)]
		public void UnitConverter_GetUnitByName_Test ()
		{
			UnitConverter target = new UnitConverter ();
			string unitName = "Celsius";
			Unit expected = unitPro.Units ["Celsius"];
			Unit actual = default(Unit);
			actual = target.GetUnitByName (unitName);
			Assert.AreEqual (expected, actual);
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_GetUnitByNameNull_Test ()
		{
			UnitConverter target = new UnitConverter ();

			Unit actual = default(Unit);
			actual = target.GetUnitByName (null);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_GetUnitByNameEmpty_Test ()
		{
			UnitConverter target = new UnitConverter ();

			Unit actual = default(Unit);
			actual = target.GetUnitByName (string.Empty);

			Assert.Fail ();
		}

		[Test]
		[TestCategory(UnitTestCategory.ExceptionTest)]
		[ExpectedException(typeof(ArgumentException))]
		public void UnitConverter_GetUnitByName_UnrecognizedName_Test ()
		{
			UnitConverter target = new UnitConverter ();
			string unitName = "BogusUnitName";
			Unit actual = default(Unit);
			actual = target.GetUnitByName (unitName);
			Assert.Fail ();
		}
		#endregion

		#region "UnitConverter.ConvertUnits"
		#region "Temperature Tests"
		#region "Source as Kelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Celcius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-173.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Celcius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-272.65), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Celcius_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "K";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-279.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-458.77), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Fahrenheit_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "K";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(500), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(500000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0005), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-07), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-138.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.12), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Reaumur_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "K";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "K";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(180), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "K";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(0.9), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Kelvin_to_Rankine_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "K";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(0), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Celsius"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celcius_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(373.15), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celcius_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(273.65), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celcius_to_Kelvin_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "C";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(273.15), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(212), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(32.9), "F");
			Measurement actual;
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Fahrenheit_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "C";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(32), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(373150), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(273650), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(373150000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(273650000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(373150000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(273650000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.37315), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.27365), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.00037315), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.00027365), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(80), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(0.4), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Reaumur_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "C";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(0), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "C";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(671.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "C";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(492.57), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Celsius_to_Rankine_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "C";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(491.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Fahrenheit"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(310.93), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(255.65), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Kelvin_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "F";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(255.37), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(37.78), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-17.5), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Celsius_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "F";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-17.78), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(310927.78), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(255650), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(310927777.78), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(255650000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(310927777777.78), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(255650000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.310927777777778), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.25565), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.000310927777778), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.00025565), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(30.22), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-14), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Reaumur_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "F";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-14.22), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "F";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(559.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "F";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(460.17), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Fahrenheit_to_Rankine_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "F";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(459.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Millikelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(0.0005), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.05), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.49), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(500), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(500000), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-07), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-10), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.44), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(0.18), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Millikelvin_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "mK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(0.0009), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Millikelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(5E-07), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0005), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(500), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-10), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-13), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(0.00018), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Microkelvin_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "µK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(9E-07), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Millikelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(5E-10), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-07), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0005), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(5E-13), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(1E-13), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0), "MK");
			//should be 0.0000000000000005; can only round to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(1.8E-07), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nK_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "nK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(9E-10), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Kilokelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(500), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(99726.85), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(226.85), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(179540.33), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(440.33), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(500000), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.0005), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(79781.48), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(181.48), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(180000), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kK_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "kK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(900), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Megakelvin"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(500000), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(99999726.85), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(499726.85), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(179999540.33), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(899540.33), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000L), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000000L), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(500000000000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(500), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(79999781.48), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(399781.48), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "MK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(180000000), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megakelvin_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "MK";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(900000), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Reaumur"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(398.15), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(273.77), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Kelvin_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Re";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(273.15), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(257), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(33.12), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Fahrenheit_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Re";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(32), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(398150), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(273775), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(398150000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(273775000), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(398150000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(273775000000L), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.39815), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.273775), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.00039815), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(0.000273775), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(125), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(0.62), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Celsius_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Re";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(0), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Rankine_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Re";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(716.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Rankine_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Re";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(492.8), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Reaumur_to_Rankine_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Re";
			string targetUnitName = "Ra";
			Measurement expected = new Measurement (Convert.ToDouble(491.67), "Ra");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Rankine"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Kelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(55.56), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Kelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(0.28), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Kelvin_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Ra";
			string targetUnitName = "K";
			Measurement expected = new Measurement (Convert.ToDouble(0), "K");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Fahrenheit_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-359.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Fahrenheit_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.17), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Fahrenheit_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Ra";
			string targetUnitName = "F";
			Measurement expected = new Measurement (Convert.ToDouble(-459.67), "F");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Millikelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(55555.56), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Millikelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "mK";
			Measurement expected = new Measurement (Convert.ToDouble(277.78), "mK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Microkelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(55555555.56), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Microkelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "µK";
			Measurement expected = new Measurement (Convert.ToDouble(277777.78), "µK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_nK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(55555555555.56), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_nK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "nK";
			Measurement expected = new Measurement (Convert.ToDouble(277777777.78), "nK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_kK_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.055555555555556), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_kK_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "kK";
			Measurement expected = new Measurement (Convert.ToDouble(0.000277777777778), "kK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Megakelvin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(5.5555555556E-05), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Megakelvin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "MK";
			Measurement expected = new Measurement (Convert.ToDouble(2.77777778E-07), "MK");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Celsius_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-217.59), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Celsius_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-272.87), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Celsius_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Ra";
			string targetUnitName = "C";
			Measurement expected = new Measurement (Convert.ToDouble(-273.15), "C");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Reaumur_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Ra";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-174.08), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Reaumur_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.5);
			string currentUnitName = "Ra";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.3), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Rankine_to_Reaumur_Test3 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0);
			string currentUnitName = "Ra";
			string targetUnitName = "Re";
			Measurement expected = new Measurement (Convert.ToDouble(-218.52), "Re");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion

		#region "Mass Tests"
		#region "Source as kg"
		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.110231131092439), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.001102311309822), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(15.747304441777), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.157473044260297), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.20462262184878), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.022046226196442), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(220.462262184878), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.20462261964415), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3527.39619495804), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kg_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(35.2739619143064), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as g"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999999), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-09), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.000110231131092), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.10231131E-06), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.015747304441777), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.00015747304426), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.002204622621849), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.2046226196E-05), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(0.220462262184878), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(0.002204622619644), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.5273961949580408), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_g_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(0.035273961914306), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as mg"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-09), "Mg");
			//should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-12), "Gg");
			//value should be 0.000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-09), "t");
			// value should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.10231131E-07), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.102311E-09), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.5747304442E-05), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.57473044E-07), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.204622622E-06), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.2046226E-08), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(0.000220462262185), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.20462262E-06), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(0.003527396194958), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mg_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.5273961914E-05), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as µg"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-09), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-12), "Mg");
			//should be 0.000000000000099999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-13), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-15), "Gg");
			//should be 0.00000000000000099999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-12), "t");
			//value should be 0.000000000000999999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.10231E-10), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.102E-12), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.5747304E-08), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.57473E-10), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.204623E-09), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.2046E-11), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.20462262E-07), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.204623E-09), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.527396195E-06), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µg_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.5273962E-08), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as ng"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-10), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-12), "kg");
			//value should be 0.000000000000999999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(1E-07), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(1E-09), "g");
			//value should be 0.000000000999999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0001), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(9.99999999E-07), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-13), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(1E-15), "Mg");
			//should be 0.000000000000000999999999, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0), "Gg");
			//value should be 0.0000000000000001, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0), "Gg");
			//value should be 9.99999999E-19, .net rounds at 15 total digits
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-13), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(1E-15), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.1E-13), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1E-15), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.5747E-11), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(1.57E-13), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.205E-12), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2.2E-14), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.20462E-10), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2.205E-12), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ng";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.527396E-09), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ng_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ng";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3.5274E-11), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Megagram"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagrams_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(100), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagrams_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.999999999), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(110.231131092439), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.10231130982208), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(15747.304441777), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(157.473044260297), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2204.62262184878), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(22.0462261964415), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(220462.262184878), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2204.62261964415), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3527396.194958), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megagram_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(35273.961914306), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Gigagram"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(999999999), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000.0), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000L), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(1E+20), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(110231.131092439), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1102.31130982208), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(15747304.441777), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(157473.044260297), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2204622.62184878), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(22046.2261964415), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(220462262.184878), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2204622.61964415), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3527396194.95804), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gg_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gg";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(35273961.9143064), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Tonnes"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000L), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(100000000), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(999999.999), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(100000000000000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(999999999000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_Megagrams_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(100), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_Megagrams_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.999999999), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(110.231131092439), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(1.10231130982208), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(2204.62262184878), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(22.0462261964415), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(15747.304441777), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(157.473044260297), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(220462.262184878), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(2204.62261964415), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "t";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3527396.194958), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonne_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "t";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(35273.961914306), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Tons"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(90718.474), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(907.184739092815), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(90718474000L), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(907184739.092815), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(90718474), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(907184.739092815), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(90718474000000.0), "µg");
			//should be 90718474000000, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(907184739092.815), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(90718474000000016L), "ng");
			//should be 90718474000000000, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(907184739092815.0), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_Megagrams_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(90.718474), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_Megagrams_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.907184739092815), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.090718474), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000907184739093), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(90.718474), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.907184739092815), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(200000), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(1999.999998), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ton";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(3200000), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ton_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ton";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(31999.999968), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Stone"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(635.029318), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(6.35029317364971), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(635029.318), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(6350.29317364971), "g");
			//actual value 6350.29318, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(635029318.0), "mg");
			//actual value 635029318, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(6350293.17364971), "mg");
			//actual value 6350293.1736, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(635029318000L), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(6350293173.64971), "µg");
			//actual value 6350293173.6, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(635029318000000L), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(6350293173649.71), "ng");
			//actual value 6350293173600, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.635029318), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.00635029317365), "Mg");
			//actual value .006350293173600, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000635029318), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(6.350293174E-06), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.635029318), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.00635029317365), "t");
			//actual value 0.006350293, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.7), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.006999999993), "ton");
			//should be 0.007, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(14), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.13999999986), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(1400), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(13.999999986), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "st";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(22400), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_stone_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "st";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(223.999999776), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as CWT"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(4535.9237), "kg");
			// actual value 4535.9237, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(45.3592369546408), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(4535923700L), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(45359236.9546408), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(4535923.7), "g");
			//should be 4535923.7, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(45359.2369546408), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);

			//var d = Math.(expected.Value);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(4535923700000.0), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(45359236954.640762), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359237E+15), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(45359236954640.8), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359237), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.045359236954641), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0045359237), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359236955E-05), "Gg");
			//actual value 0.000045359, .net bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359237), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.045359236954641), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(5), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.04999999995), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(714.285714285714), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(7.14285713571429), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(10000), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(99.9999999), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cwt";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(160000), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cwt_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cwt";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(1599.9999984), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Pound"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(45.359237), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(0.453592369546408), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(45359.237), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(453.592369546408), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(45359237), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(453592.369546408), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(45359237000.0), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(453592369.546408), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(45359237000000.0), "ng");
			//should be 45359237000000, .net conversion bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(453592369546.41), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.045359237), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.000453592369546), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359237E-05), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(4.5359237E-07), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.045359237), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.000453592369546), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.05), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.0004999999995), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(7.14285714285714), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.071428571357143), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(1), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.00999999999), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_oz_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(1600), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lb_to_oz_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb";
			string targetUnitName = "oz";
			Measurement expected = new Measurement (Convert.ToDouble(15.999999984), "oz");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Ounce"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_kg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(2.8349523125), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_kg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "kg";
			Measurement expected = new Measurement (Convert.ToDouble(0.02834952309665), "kg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_g_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(2834.9523125), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_g_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "g";
			Measurement expected = new Measurement (Convert.ToDouble(28.3495230966505), "g");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_mg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(2834952.3125), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_mg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "mg";
			Measurement expected = new Measurement (Convert.ToDouble(28349.5230966505), "mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_µg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(2834952312.5), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_µg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "µg";
			Measurement expected = new Measurement (Convert.ToDouble(28349523.0966505), "µg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(2834952312500.0), "ng");
			//should be 2834952312500, .net conversion bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_ng_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "ng";
			Measurement expected = new Measurement (Convert.ToDouble(28349523096.6505), "ng");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_Megagram_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(0.0028349523125), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_Megagram_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "Mg";
			Measurement expected = new Measurement (Convert.ToDouble(2.8349523097E-05), "Mg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_Gg_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(2.834952313E-06), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_Gg_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "Gg";
			Measurement expected = new Measurement (Convert.ToDouble(2.8349523E-08), "Gg");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_tonne_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(0.0028349523125), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_tonne_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "t";
			Measurement expected = new Measurement (Convert.ToDouble(2.8349523097E-05), "t");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_ton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(0.003125), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_ton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "ton";
			Measurement expected = new Measurement (Convert.ToDouble(3.1249999969E-05), "ton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_stone_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.446428571428571), "st");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_stone_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "st";
			Measurement expected = new Measurement (Convert.ToDouble(0.004464285709821), "st");
			//UK stone; US stone 0.005
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_cwt_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.0625), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_cwt_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "cwt";
			Measurement expected = new Measurement (Convert.ToDouble(0.000624999999375), "cwt");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_lb_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "oz";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(6.25), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_oz_to_lb_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "oz";
			string targetUnitName = "lb";
			Measurement expected = new Measurement (Convert.ToDouble(0.0624999999375), "lb");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion

		#region "Time Tests"
		#region "Source as Seconds"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_min_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "s";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(1.66666666666667), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_min_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "s";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(0.01666666665), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_hr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "s";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(0.027777777777778), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_hr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "s";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(0.0002777777775), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_ms_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "s";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(100000), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_ms_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "s";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(999.999999), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_day_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "s";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(0.001157407407407), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_day_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "s";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(1.1574074062E-05), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_wk_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "s";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(0.000165343915344), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_sec_to_wk_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "s";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(1.653439152E-06), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Minutes"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_sec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "min";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(6000), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_sec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "min";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(59.99999994), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_hr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "min";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(1.66666666666667), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_hr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "min";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(0.01666666665), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_ms_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "min";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(6000000), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_ms_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "min";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(59999.99994), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_day_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "min";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(0.069444444444444), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_day_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "min";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(0.00069444444375), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_wk_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "min";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(0.009920634920635), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_min_to_wk_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "min";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(9.9206349107E-05), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Hours"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_sec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "hr";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(360000), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_sec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "hr";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(3599.9999964), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_min_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "hr";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(6000), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_min_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "hr";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(59.99999994), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_ms_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "hr";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(360000000), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_ms_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "hr";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(3599999.9964), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_day_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "hr";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(4.16666666666667), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_day_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "hr";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(0.041666666625), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_wk_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "hr";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(0.595238095238095), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_hr_to_wk_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "hr";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(0.005952380946429), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Milliseconds"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_sec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ms";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(0.1), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_sec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ms";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(0.000999999999), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_min_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ms";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(0.001666666666667), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_min_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ms";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(1.666666665E-05), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_hr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ms";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(2.7777777778E-05), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_hr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ms";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(2.77777778E-07), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_day_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ms";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(1.157407407E-06), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_day_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ms";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(1.1574074E-08), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_wk_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ms";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(1.65343915E-07), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ms_to_wk_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ms";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(1.653439E-09), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Days"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_sec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "d";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(8640000), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_sec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "d";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(86399.9999136), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_min_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "d";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(144000), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_min_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "d";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(1439.99999856), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_hr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "d";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(2400), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_hr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "d";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(23.999999976), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_ms_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "d";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(8640000000L), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_ms_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "d";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(86399999.9136), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_wk_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "d";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(14.2857142857143), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_day_to_wk_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "d";
			string targetUnitName = "wk";
			Measurement expected = new Measurement (Convert.ToDouble(0.142857142714286), "wk");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion

		#region "Source as Weeks"

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_sec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "wk";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(60480000), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_sec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "wk";
			string targetUnitName = "s";
			Measurement expected = new Measurement (Convert.ToDouble(604799.9993952), "s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_min_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "wk";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(1008000), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_min_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "wk";
			string targetUnitName = "min";
			Measurement expected = new Measurement (Convert.ToDouble(10079.99998992), "min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_hr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "wk";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(16800), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_hr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "wk";
			string targetUnitName = "hr";
			Measurement expected = new Measurement (Convert.ToDouble(167.999999832), "hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_ms_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "wk";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(60480000000L), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_ms_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "wk";
			string targetUnitName = "ms";
			Measurement expected = new Measurement (Convert.ToDouble(604799999.3952), "ms");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCategory(UnitTestCategory.Integration)]
		[TestCategory(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_day_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "wk";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(700), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_wk_to_day_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "wk";
			string targetUnitName = "d";
			Measurement expected = new Measurement (Convert.ToDouble(6.999999993), "d");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion


		#endregion
	}
}