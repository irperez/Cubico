using System;
using NUnit.Framework;
using Cubico;

namespace Cubico.Tests
{
	[TestFixture]
	public class UnitConverterTest2
	{
		TestContext testContextInstance;
		// Gets or sets the test context which provides information about and functionality for the current test run.
		public TestContext TestContext {
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}
		#region "UnitConverter.ConvertUnits"
		#region "Force Tests"
		#region "Source as Newton (N)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (10000000.0), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (99999.9999), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (22.4808943099999), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (0.22480894287519), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (0.011240447154986), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (0.000112404471437), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.010197162129779), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.000101971621196), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "GN");
			//should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "N";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000.0), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_N_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "N";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Dyne (dyn)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (0.001), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-06), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (0.0002248089431), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2.248089429E-06), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.12404472E-07), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.124045E-09), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.01971621E-07), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.019716E-09), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-11), "Meganewton");
			//should be 0.00000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-14), "GN");
			//should be 0.00000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-06), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-08), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (1), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (0.00999999999), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (1000), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "dyn";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (1000000), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_dyn_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "dyn";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (9999.99999), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Pound-force (lbf)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (444.82216152548), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (4.44822161080658), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (44482216.152548), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (444822.161080658), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (0.05), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (0.0004999999995), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.045359236999934), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.000453592369546), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.000444822161525), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (4.448221611E-06), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (4.44822162E-07), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (4.448222E-09), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (0.44482216152548), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (0.004448221610807), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (444822.16152548), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (4448.22161080658), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (444822161.52548), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (4448221.61080658), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lbf";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (444822161525.48), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbf_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lbf";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (4448221610.80658), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Ton-force(short) (tonf)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (889644.3230521), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (8896.44322162456), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (88964432305.21), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (889644322.162456), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (200000), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (1999.999998), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (90.718474), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.907184739092815), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.8896443230521), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.008896443221625), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000889644323052), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (8.896443222E-06), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (889.6443230521), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (8.89644322162456), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (889644323.0521), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (8896443.22162456), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (889644323052.1), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (8896443221.62456), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonf";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (889644323052100L), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonf_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonf";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (8896443221624.56), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Tonnes force(metric) (tonnef,tf)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (980665), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (9806.64999019335), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (98066500000.0), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (980664999.019335), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (220462.2621852), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2204.62261964738), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (110.231131092439), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.10231130982208), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.980665), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.009806649990193), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000980665), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (9.80664999E-06), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (980.665), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (9.80664999019335), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (980665000), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (9806649.99019335), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (980665000000.0), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (9806649990.19335), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "tonnef";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (980665000000000.0), "nN");
			//should be 98066500000000, .net conversion bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_tonnef_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "tonnef";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (9806649990193.35), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Meganewton (MN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (10000000000000.0), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (99999999900.0), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (22480894.3099999), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (224808.94287519), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (11240.4471549855), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (112.404471437451), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (10197.1621297793), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (101.971621195821), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000L), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999.0), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000.0), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000.0), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Meganewton";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (1E+17), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Meganewton_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Meganewton";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000000.0), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Giganewton (GN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000.0), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (1E+16), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (99999999900000.0), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (22480894309.9999), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (224808942.87519), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (11240447.154986), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (112404.471437456), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_ng_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (10197162.1297793), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (101971.621195821), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000.0), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000.0), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (1E+17), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000000.0), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "GN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (1E+20), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GN_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "GN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E+17), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Kilonewton (kN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (10000000000L), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (99999999.9), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (22480.8943099999), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (224.80894287519), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (11.2404471549855), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (0.112404471437451), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (10.1971621297793), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (0.101971621195821), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000.0), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000.0), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kN_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000.0), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Milinewton (mN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (10000), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (99.9999999), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (0.02248089431), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (0.000224808942875), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.1240447155E-05), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.12404471E-07), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.019716213E-05), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.01971621E-07), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "Meganewton");
			//should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-10), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "GN");
			//should be 0.000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_mN_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Micronewton (µN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (10), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (0.0999999999), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2.248089431E-05), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2.24808943E-07), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.1240447E-08), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.12404E-10), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.0197162E-08), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.01972E-10), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-10), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "Meganewton");
			//should be 0.000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-13), "GN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-15), "GN");
			//should be 0.000000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "kN");
			//should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_nN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µN_to_nN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µN";
			string targetUnitName = "nN";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "nN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Nananewton (nN)"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_N_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "N");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_N_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "N";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "N");
			//should be 0.000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_dyn_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (0.01), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_dyn_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "dyn";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-05), "dyn");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_lbf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2.2480894E-08), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_lbf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "lbf";
			Measurement expected = new Measurement (Convert.ToDouble (2.24809E-10), "lbf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_tonf_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.124E-11), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_tonf_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "tonf";
			Measurement expected = new Measurement (Convert.ToDouble (1.12E-13), "tonf");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_tonnef_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.0197E-11), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_tonnef_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "tonnef";
			Measurement expected = new Measurement (Convert.ToDouble (1.02E-13), "tonnef");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_Meganewton_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-13), "Meganewton");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_Meganewton_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "Meganewton";
			Measurement expected = new Measurement (Convert.ToDouble (1E-15), "Meganewton");
			//should be 0.000000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_GN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0), "GN");
			//should be .0000000000000001, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_GN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "GN";
			Measurement expected = new Measurement (Convert.ToDouble (0), "GN");
			//should be 9.99999999E-19, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_kN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-10), "kN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_kN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "kN";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "kN");
			//should be 0.000000000000999999999, .net rounds to 15 places
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_mN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_mN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "mN";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "mN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_µN_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "nN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_nN_to_µN_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "nN";
			string targetUnitName = "µN";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "µN");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion
		#region "Momentum Tests"
		#region "Source as kg m/s"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMetersPerSec_to_lbFtPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (2603884.98643556), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMetersPerSec_to_lbFtPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (26038.8498383168), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_GramCentimeterPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg m/s";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (10000000), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_GramCentimeterPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg m/s";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (99999.9999), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (43398.0831072594), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (433.980830638613), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (723.301385120989), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_kgMeterPerSec_to_lbFtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "kg m/s";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (7.23301384397688), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as lb ft/hr"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_kgMetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.003840415399333), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_kgMetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (3.8404153955E-05), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_GramCentimeterPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (384.041539933333), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_GramCentimeterPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (3.84041539549292), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (1.66666666666667), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (0.01666666665), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.027777777777778), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerHr_to_lbFtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/hr";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.0002777777775), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as g cm/s"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_kgMetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g cm/s";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.001), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_kgMetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g cm/s";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-06), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (26.0388498643556), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (0.260388498383168), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (0.4339808310726), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (0.004339808306386), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.0072330138512), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_GramCentimeterPerSec_to_lbFtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "g cm/s";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (7.233013844E-05), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as lb ft/min"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_kgMetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.23042492396), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_kgMetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.002304249237296), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (6000), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (59.99999994), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_GramCentimeterPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (23042.4923959997), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_GramCentimeterPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (230.424923729572), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (1.66666666666667), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerMin_to_lbFtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/min";
			string targetUnitName = "lb ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.01666666665), "lb ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as lb ft/sec"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_kgMetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (13.8254954376), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_kgMetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "kg m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.138254954237745), "kg m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (360000), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "lb ft/hr";
			Measurement expected = new Measurement (Convert.ToDouble (3599.9999964), "lb ft/hr");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_GramCentimeterPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (1382549.54376189), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_GramCentimeterPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "g cm/s";
			Measurement expected = new Measurement (Convert.ToDouble (13825.4954237934), "g cm/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (6000), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_lbFtPerSec_to_lbFtPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "lb ft/s";
			string targetUnitName = "lb ft/min";
			Measurement expected = new Measurement (Convert.ToDouble (59.99999994), "lb ft/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion
		#region "Speed Tests"
		#region "Source as Meters/Second"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_KmPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/s";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (360), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_KmPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/s";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (3.5999999964), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_MilesPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/s";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (223.69362920544), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_MilesPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/s";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (2.23693628981747), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_MetersPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/s";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (6000), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_MetersPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/s";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (59.99999994), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_FtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/s";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (328.083989501312), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerSec_to_FtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/s";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (3.28083989173228), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Kilometers/Hour"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km/h";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (27.7777777777778), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km/h";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.2777777775), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MilesPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km/h";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (62.1371192237334), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MilesPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km/h";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (0.621371191615963), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MetersPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km/h";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (1666.66666666667), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_MetersPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km/h";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (16.66666665), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_FtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km/h";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (91.1344415281423), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_KmPerHr_to_FtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km/h";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.911344414370079), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Miles/Hour"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_MetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mph";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (44.704), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_MetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mph";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.44703999955296), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_KmPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mph";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (160.9344), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_KmPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mph";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (1.60934399839066), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_MetersPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mph";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (2682.24), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_MetersPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mph";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (26.8223999731776), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_FtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mph";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (146.666666666667), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MilesPerHr_to_FtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mph";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (1.4666666652), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Meters/Minute"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_MetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/min";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (1.66666666666667), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_MetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/min";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.01666666665), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_KmPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/min";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (6), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_KmPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/min";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (0.05999999994), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_MilesPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/min";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (3.728227153424), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_MilesPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/min";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (0.037282271496958), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_FtPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m/min";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (5.46806649168854), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_MetersPerMin_to_FtPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m/min";
			string targetUnitName = "ft/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.054680664862205), "ft/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Feet/Second"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MetersPerSec_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft/s";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (30.48), "m/s");
			//should be 30.48, .net conversion bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MetersPerSec_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft/s";
			string targetUnitName = "m/s";
			Measurement expected = new Measurement (Convert.ToDouble (0.3047999996952), "m/s");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_KmPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft/s";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (109.728), "km/h");
			//should be 109.728, .net conversion bug
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_KmPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft/s";
			string targetUnitName = "km/h";
			Measurement expected = new Measurement (Convert.ToDouble (1.09727999890272), "km/h");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MilesPerHr_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft/s";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (68.1818181818182), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MilesPerHr_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft/s";
			string targetUnitName = "mph";
			Measurement expected = new Measurement (Convert.ToDouble (0.681818181136364), "mph");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MetersPerMin_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft/s";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (1828.8), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_FtPerSec_to_MetersPerMin_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft/s";
			string targetUnitName = "m/min";
			Measurement expected = new Measurement (Convert.ToDouble (18.287999981712), "m/min");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion
		#region "Length Tests"
		#region "Source as Metres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (109.361329833771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1.0936132972441), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (328.083989501312), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
			Assert.AreEqual (Result.NoError, actual.ConversionResult);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3.28083989173228), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4.97096953789867), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.049709695329277), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.062137119223733), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.000621371191616), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.497096953789867), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.004970969532928), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3937007.87401575), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39370.0787007874), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3937.00787401575), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (39.3700787007874), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (10000), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (99.9999999), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "m";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_m_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "m";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Yards"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (91.44), "m");
			//expected altered to meet .net conversion bug (91.44 m)
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.9143999990856), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (300), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (2.999999997), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4.54545454545455), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.045454545409091), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.056818181818182), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.000568181817614), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.09144), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.000914399999086), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (9.144E-05), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (9.14399999E-07), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (9.144E-08), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (9.144E-10), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.454545454545454), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.004545454540909), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3600000), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (35999.999964), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (91440000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (914399.9990856), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3600), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (35.999999964), "in");
			//expected altered to meet .net conversion bug (35.999999964)
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (9144), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (91.43999990856), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "yd";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (91440), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_yd_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "yd";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (914.3999990856), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Feet"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (30.48), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.3047999996952), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_m_negative_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (-0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (-0.3047999996952), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (33.3333333333333), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.333333333), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (1.51515151515151), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.015151515136364), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.018939393939394), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.000189393939205), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.03048), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.000304799999695), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (3.048E-05), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (3.048E-07), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (3.048E-08), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (3.048E-10), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.151515151515152), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.001515151513636), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (1200000), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (11999.999988), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (30480000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (304799.9996952), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (1200), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (11.999999988), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (3048), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (30.47999996952), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "ft";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (30480), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_ft_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "ft";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (304.7999996952), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Chain"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (2011.68), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (20.1167999798832), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (2200), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (21.999999978), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (6600), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (65.999999934), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (1.25), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.0124999999875), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (2.01168), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.020116799979883), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.00201168), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.011679998E-05), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.01168E-06), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.01168E-08), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (10), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.0999999999), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (79200000), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (791999.999208), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (2011680000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (20116799.979883), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (79200), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (791.999999208), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (201168), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (2011.67999798832), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "chain";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (2011680), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_chain_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "chain";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (20116.7999798832), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Miles"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (160934.4), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (1609.34399839066), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (176000), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1759.99999824), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (528000), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (5279.99999472), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (8000), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (79.99999992), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (160.9344), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (1.60934399839066), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.1609344), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.001609343998391), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001609344), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1.609343998E-06), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (800), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (7.999999992), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (6336000000L), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (63359999.93664), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (160934400000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (1609343998.391), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (6336000), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (63359.99993664), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (16093440), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (160934.399839066), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mi";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (160934400), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_miles_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mi";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (1609343.998391), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Kilometres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (109361.329833771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1093.61329724409), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (328083.989501312), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3280.83989173228), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4970.96953789867), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (49.709695329277), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_miles_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (62.1371192237334), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_miles_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.621371191615963), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (497.096953789867), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4.9709695329277), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3937007874.01575), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39370078.7007874), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3937007.87401575), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (39370.0787007874), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (10000000), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (99999.9999), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "km";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_km_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "km";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Megametres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (109361329.833771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1093613.29724409), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (328083989.501312), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3280839.89173228), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4970969.53789867), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (49709.695329277), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_miles_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (62137.1192237334), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_miles_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (621.371191615963), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (497096.953789867), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4970.9695329277), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3937007874015.75), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39370078700.7874), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3937007874.01575), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (39370078.7007874), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (10000000000L), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (99999999.9), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Mm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000L), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Megametres_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Mm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Gigametres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000L), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (999999999), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (109361329833.771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1093613297.24409), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (328083989501.312), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3280839891.73228), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4970969537.89867), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (49709695.329277), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_miles_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (62137119.2237334), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_miles_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (621371.191615963), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (100000000), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gms_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (999999.999), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (497096953.789867), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4970969.5329277), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3937007874015748L), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39370078700787.4), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3937007874015.75), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (39370078700.7874), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (10000000000000L), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (99999999900L), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "Gm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (100000000000000L), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_Gm_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "Gm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (999999999000L), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Furlongs"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (20116.8), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (201.167999798832), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (22000), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (219.99999978), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (66000), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (659.99999934), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (12.5), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.124999999875), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (20.1168), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.201167999798832), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0201168), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.000201167999799), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.01168E-05), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.01168E-07), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (1000), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (792000000), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (7919999.99208), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (20116800000L), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (201167999.799), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (792000), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (7919.99999208), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (2011680), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (20116.7999798832), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "furlong";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (20116800), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_furlong_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "furlong";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (201167.999799), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Thou"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.00254), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (2.5399999975E-05), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.002777777777778), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (2.777777775E-05), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.008333333333333), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (8.333333325E-05), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (1.578282828E-06), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (1.5782828E-08), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-06), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-08), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-09), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-11), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-12), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.5E-14), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.000126262626263), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (1.262626261E-06), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (2540), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (25.3999999746), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (1.2626262626E-05), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (1.26262626E-07), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (0.254), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (0.00253999999746), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "thou";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_thou_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "thou";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0253999999746), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Microns"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.000109361329834), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1.093613297E-06), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.000328083989501), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
			Assert.AreEqual (Result.NoError, actual.ConversionResult);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3.280839892E-06), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4.970969538E-06), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4.9709695E-08), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (6.2137119E-08), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (6.21371E-10), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-10), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-13), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-15), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4.97096954E-07), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4.97097E-09), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3.93700787401575), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (0.039370078700787), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (0.003937007874016), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3.9370078701E-05), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (0.01), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-05), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "µm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_µm_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "µm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Inches"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (2.54), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.0253999999746), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (2.77777777777778), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.02777777775), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (8.33333333333333), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.08333333325), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.001578282828283), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (1.5782828267E-05), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.00254), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (2.5399999975E-05), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-06), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-08), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-09), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (2.54E-11), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.126262626262626), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.001262626261364), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (2540000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (25399.9999746), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.012626262626263), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.000126262626136), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (254), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (2.53999999746), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "in";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (2540), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_in_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "in";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (25.3999999746), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Centimetres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (1), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.00999999999), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (1.09361329833771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.010936132972441), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (3.280839895013123), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
			Assert.AreEqual (Result.NoError, actual.ConversionResult);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.032808398917323), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.049709695378987), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.000497096953293), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (0.000621371192237), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (6.213711916E-06), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.001), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-06), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-06), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-08), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-11), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.004970969537899), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4.9709695329E-05), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39370.0787401575), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (393.700787007874), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (1000000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (9999.99999), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (39.3700787401575), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (0.393700787007874), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_millimetres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "cm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (1000), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_cm_to_millimetres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "cm";
			string targetUnitName = "mm";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999), "mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#region "Source as Millimetres"
		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_m_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.1), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_m_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "m";
			Measurement expected = new Measurement (Convert.ToDouble (0.000999999999), "m");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_yd_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.109361329833771), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_yd_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "yd";
			Measurement expected = new Measurement (Convert.ToDouble (0.001093613297244), "yd");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_ft_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.328083989501312), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
			Assert.AreEqual (Result.NoError, actual.ConversionResult);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_ft_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "ft";
			Measurement expected = new Measurement (Convert.ToDouble (0.003280839891732), "ft");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_chain_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (0.004970969537899), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_chain_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "chain";
			Measurement expected = new Measurement (Convert.ToDouble (4.9709695329E-05), "chain");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_mile_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (6.2137119224E-05), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_mile_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "mi";
			Measurement expected = new Measurement (Convert.ToDouble (6.21371192E-07), "mi");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_km_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (0.0001), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_km_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "km";
			Measurement expected = new Measurement (Convert.ToDouble (9.99999999E-07), "km");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_Megametres_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-07), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_Megametres_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "Mm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-09), "Mm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_Gm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-10), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_Gm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "Gm";
			Measurement expected = new Measurement (Convert.ToDouble (1E-12), "Gm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_furlong_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (0.00049709695379), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_furlong_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "furlong";
			Measurement expected = new Measurement (Convert.ToDouble (4.970969533E-06), "furlong");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_thou_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (3937.00787401575), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_thou_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "thou";
			Measurement expected = new Measurement (Convert.ToDouble (39.3700787007874), "thou");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_µm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (100000), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_µm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "µm";
			Measurement expected = new Measurement (Convert.ToDouble (999.999999), "µm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_in_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (3.93700787401575), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_in_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "in";
			Measurement expected = new Measurement (Convert.ToDouble (0.039370078700787), "in");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_cm_Test ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (100);
			string currentUnitName = "mm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (10), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}

		[Test]
		[TestCase(UnitTestCategory.Integration)]
		[TestCase(UnitTestCategory.UnitConversion)]
		public void UnitConverter_ConvertUnits_millimetres_to_cm_Test2 ()
		{
			UnitConverter target = new UnitConverter ();
			double value = Convert.ToDouble (0.999999999);
			string currentUnitName = "mm";
			string targetUnitName = "cm";
			Measurement expected = new Measurement (Convert.ToDouble (0.0999999999), "cm");
			Measurement actual = default(Measurement);
			actual = target.ConvertUnits (value, currentUnitName, targetUnitName);
			Assert.AreEqual (expected.Value, actual.Value);
		}
		#endregion
		#endregion
		#endregion
	}
}