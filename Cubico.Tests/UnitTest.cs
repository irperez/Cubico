using System;
using System.Diagnostics.Contracts;
using Cubico;
using NUnit.Framework;
using System.Collections.ObjectModel;

[TestFixture]
public class UnitTest
{
	TestContext testContextInstance;
	UnitProvider unitPro = new UnitProvider ();
	// Gets or sets the test context which provides information about and functionality for the current test run.
	public TestContext TestContext {
		get { return testContextInstance; }
		set { testContextInstance = value; }
	}
	#region "Unit.Unit()"
	[Test]
	public void UnitNewTest ()
	{
		Unit testObj = new Unit ();

		Assert.IsNotNull (testObj);
		Assert.IsTrue (testObj.ID == 0);
		Assert.IsTrue (string.IsNullOrEmpty (testObj.DefaultSymbol));
		Assert.IsNull (testObj.UnitType);
		Assert.IsNotNull (testObj.Symbols);
		Assert.IsTrue (testObj.Symbols.Count == 0);
		Assert.IsNotNull (testObj.Modifiers);
		Assert.IsTrue (testObj.Modifiers.Count == 0);
		Assert.IsTrue (string.IsNullOrEmpty (testObj.Name));
	}
	#endregion
	#region "Unit.Unit(UnitType)"
	[Test]
	[ExpectedException(typeof(ArgumentNullException))]
	public void UnitNewEfUnitUnitTypeNullTest ()
	{
		Unit testObj = new Unit (null);

		Assert.Fail ("Constructor should cause a ContractException.  Nulls are not allowed");
	}

	[Test]
	public void UnitNewEfUnitUnitTypeTest ()
	{
		UnitType testunittype = new UnitType {
			ID = 99,
			Name = "Name"
		};
		Unit testObj = new Unit (testunittype);

		Assert.IsNotNull (testObj);
		Assert.IsNotNull (testObj.UnitType);
		Assert.IsTrue (testObj.UnitTypeID == 99);
		Assert.AreEqual (testunittype.Name, testObj.UnitType.Name);

		Assert.IsNotNull (testObj.Symbols);
		Assert.IsTrue (testObj.Symbols.Count == 0);

		Assert.IsNotNull (testObj.Modifiers);
		Assert.IsTrue (testObj.Modifiers.Count == 0);
		// Assert.IsTrue(testUnit.UnitModifiers(0).Value = testObj.Modifiers(0).Value)
	}
	#endregion
	#region "Unit.ParentType"
	[Test]
	public void UnitParentTypeTest ()
	{
		UnitType testUnitType = new UnitType {
			ID = 99,
			Name = "Name"
		};

		Unit testObj = new Unit ();

		testObj.UnitType = testUnitType;

		Assert.IsNotNull (testObj.UnitType);
		Assert.AreEqual (testUnitType.ID, testObj.UnitType.ID);
		Assert.AreEqual (testUnitType.Name, testObj.UnitType.Name);
	}

	[Test]
	public void UnitParentTypeNullTest ()
	{
		Unit testObj = new Unit ();

		testObj.UnitType = null;

		Assert.IsNull (testObj.UnitType);
	}
	#endregion
	#region "Unit.ID"
	[Test]
	public void UnitIDTest ()
	{
		Unit testObj = new Unit ();

		testObj.ID = 99;

		Assert.AreEqual (99, testObj.ID);
	}
	#endregion
	#region "Unit.Name"
	[Test]
	public void UnitNameTest ()
	{
		Unit testObj = new Unit ();

		testObj.Name = "Test Name";

		Assert.AreEqual ("Test Name", testObj.Name);
	}
	#endregion
	#region "IEquatable"
	[Test]
	public void Unit_EqualityTest ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected == target);
	}

	[Test]
	public void Unit_EqualityTest2 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void Unit_EqualityTest3 ()
	{
		Unit expected = null;
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void Unit_EqualityTest4 ()
	{
		Unit expected = unitPro.Units ["Inch"];
		Unit target = null;

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void Unit_EqualityTest5 ()
	{
		Unit expected = null;
		Unit target = null;

		Assert.IsTrue (expected == target);
	}

	[Test]
	public void Unit_EqualityTest6 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void Unit_EqualityTest7 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void Unit_EqualityTest8 ()
	{
		Unit expected = null;
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void Unit_EqualityTest8_1 ()
	{
		Unit expected = null;
		Unit target = null;

		Assert.IsFalse (expected != target);
	}

	[Test]
	public void Unit_EqualityTest9 ()
	{
		Unit expected = unitPro.Units ["Inch"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void Unit_EqualityTest10 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.Equals (target));
	}

	[Test]
	public void Unit_EqualityTest11 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void Unit_EqualityTest12 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void Unit_EqualityTest13 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.Equals ((object)target));
	}

	[Test]
	public void Unit_EqualityTest14 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected.Equals ((object)target));
	}

	[Test]
	public void Unit_EqualityTest154 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsFalse (expected.Equals ((object)target));
	}

	[Test]
	public void Unit_EqualityTest15 ()
	{
		Unit expected = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.GetHashCode () == expected.Name.GetHashCode ());
	}
	#endregion
}