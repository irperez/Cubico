using System;
using Cubico;
using NUnit.Framework;

namespace Cubico.Tests
{
	[TestFixture]
	public class SymbolTest
	{
		TestContext testContextInstance;
		UnitProvider unitPro = new UnitProvider ();
		// Gets or sets the test context which provides information about and functionality for the current test run.
		public TestContext TestContext {
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}
		#region "Symbol.Symbol()"
		[Test]
		public void SymbolNewTest ()
		{
			Symbol testObj = new Symbol ();

			Assert.IsNotNull (testObj);
			Assert.IsTrue (testObj.Id == 0);
			Assert.IsTrue (testObj.Value == null);
			Assert.IsNull (testObj.Unit);
		}
		#endregion
		#region "Symbol.Symbol(Unit)"
		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void SymbolNewEfUnitSymbolUnitNullTest ()
		{
			Symbol testObj = new Symbol (null);

			Assert.Fail ("Null values are not allowed for this constructor.");
		}

		[Test]
		public void SymbolNewEfUnitSymbolUnitTest ()
		{
			Unit unitObj = new Unit {
				ID = 99,
				Name = "Name"
			};
			Symbol testObj = new Symbol (unitObj);

			Assert.IsNotNull (testObj);

			Assert.IsTrue (string.IsNullOrEmpty (testObj.Value));

			Assert.IsNotNull (testObj.Unit);
			Assert.IsTrue (testObj.Unit.ID == unitObj.ID);
		}
		#endregion
		#region "Symbol.ID"
		[Test]
		public void SymbolIDNullTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Id = null;

			Assert.AreEqual (null, testObj.Id);
		}

		[Test]
		public void SymbolIDTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Id = 99;

			Assert.AreEqual (99, testObj.Id);
		}
		#endregion
		#region "Symbol.ParentUnit"
		[Test]
		public void SymbolParentUnitTest ()
		{
			Unit testUnitObj = new Unit ();
			Symbol testObj = new Symbol (testUnitObj);
			testObj.Unit = testUnitObj;

			Assert.IsNotNull (testObj.Unit);
			Assert.AreEqual (testUnitObj.ID, testObj.Unit.ID);
			Assert.AreEqual (testUnitObj.Name, testObj.Unit.Name);
		}

		[Test]
		public void SymbolParentUnitNullTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Unit = null;

			Assert.IsNull (testObj.Unit);
		}
		#endregion
		#region "Symbol.Value"
		[Test]
		public void SymbolValueTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Value = "Test Name";

			Assert.AreEqual ("Test Name", testObj.Value);
		}
		#endregion
		#region "Symbol.IsDefault"
		[Test]
		public void SymbolIsDefaultTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.IsDefault = true;

			Assert.AreEqual (true, testObj.IsDefault);
		}
		#endregion
		#region "IEquatable"
		[Test]
		public void Symbol_EqualityTest ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected == target);
		}

		[Test]
		public void Unit_EqualityTest2 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected == target);
		}

		[Test]
		public void Unit_EqualityTest3 ()
		{
			Symbol expected = null;
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected == target);
		}

		[Test]
		public void Unit_EqualityTest4 ()
		{
			Symbol expected = unitPro.Symbols ["in"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected == target);
		}

		[Test]
		public void Unit_EqualityTest5 ()
		{
			Symbol expected = null;
			Symbol target = null;

			Assert.IsTrue (expected == target);
		}

		[Test]
		public void Unit_EqualityTest6 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsTrue (expected != target);
		}

		[Test]
		public void Unit_EqualityTest7 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsTrue (expected != target);
		}

		[Test]
		public void Unit_EqualityTest8 ()
		{
			Symbol expected = null;
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected != target);
		}

		[Test]
		public void Unit_EqualityTest8_1 ()
		{
			Symbol expected = null;
			Symbol target = null;

			Assert.IsFalse (expected != target);
		}

		[Test]
		public void Unit_EqualityTest9 ()
		{
			Symbol expected = unitPro.Symbols ["in"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsFalse (expected.Equals (target));
		}

		[Test]
		public void Unit_EqualityTest10 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.Equals (target));
		}

		[Test]
		public void Unit_EqualityTest11 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected.Equals (target));
		}

		[Test]
		public void Unit_EqualityTest12 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected.Equals (target));
		}

		[Test]
		public void Unit_EqualityTest13 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.Equals ((object)target));
		}

		[Test]
		public void Unit_EqualityTest14 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected.Equals ((object)target));
		}

		[Test]
		public void Unit_EqualityTest154 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected.Equals ((object)target));
		}

		[Test]
		public void Unit_EqualityTest15 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.GetHashCode () == expected.Value.GetHashCode ());
		}
		#endregion
	}
}