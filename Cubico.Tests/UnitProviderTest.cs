using System;
using System.Collections.Generic;
using NUnit.Framework;
using Cubico;

namespace Cubico.Tests
{
	// This is a test class for UnitProvider and is intended to contain all UnitProvider Unit Tests
	[TestFixture]
	public class UnitProviderTest
	{
		TestContext testContextInstance;
		UnitProvider unitPro = new UnitProvider ();
		// Gets or sets the test context which provides information about and functionality for the current test run.
		public TestContext TestContext {
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}
		// A test for UnitTypes
		[Test]
		public void UnitTypesTest ()
		{
			Dictionary<string, UnitType> actual = default(Dictionary<string, UnitType>);
			actual = unitPro.UnitTypes;

			Assert.IsNotNull (actual);
			Assert.IsTrue (actual.Count > 0);
		}
		// A test for Units
		[Test]
		public void UnitsTest ()
		{
			Dictionary<string, Unit> actual = default(Dictionary<string, Unit>);
			actual = unitPro.Units;

			Assert.IsNotNull (actual);
			Assert.IsTrue (actual.Count > 0);
		}
		// A test for Symbols
		[Test]
		public void SymbolsTest ()
		{
			Dictionary<string, Unit> actual = default(Dictionary<string, Unit>);
			actual = unitPro.Symbols;

			Assert.IsNotNull (actual);
			Assert.IsTrue (actual.Count > 0);
		}
	}
}