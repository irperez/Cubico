using System;
using Cubico;
using NUnit.Framework;

[TestFixture]
public class UnitTypeTest
{
	TestContext testContextInstance;
	UnitProvider unitPro = new UnitProvider ();
	// Gets or sets the test context which provides information about and functionality for the current test run.
	public TestContext TestContext {
		get { return testContextInstance; }
		set { testContextInstance = value; }
	}
	#region "UnitType.UnitType()"
	[Test]
	public void UnitTypeNewTest ()
	{
		UnitType testObj = new UnitType ();

		Assert.IsNotNull (testObj);
		Assert.IsTrue (testObj.ID == 0);
		Assert.IsNotNull (testObj.Units);
		Assert.IsTrue (testObj.Units.Count == 0);
		Assert.IsTrue (string.IsNullOrEmpty (testObj.Name));
	}
	#endregion
	#region "UnitType.ID"
	[Test]
	public void UnitTypeIDTest ()
	{
		UnitType testObj = new UnitType ();

		testObj.ID = 99;

		Assert.AreEqual (99, testObj.ID);
	}
	#endregion
	#region "UnitType.Name"
	[Test]
	public void UnitTypeNameTest ()
	{
		UnitType testObj = new UnitType ();

		testObj.Name = "Test Name";

		Assert.AreEqual ("Test Name", testObj.Name);
	}
	#endregion
	#region "IEquatable"
	[Test]
	public void UnitType_EqualityTest ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Length"];

		Assert.IsTrue (expected == target);
	}

	[Test]
	public void UnitType_EqualityTest2 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Mass"];

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void UnitType_EqualityTest3 ()
	{
		UnitType expected = null;
		UnitType target = unitPro.UnitTypes ["Mass"];

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void UnitType_EqualityTest4 ()
	{
		UnitType expected = unitPro.UnitTypes ["Mass"];
		UnitType target = null;

		Assert.IsFalse (expected == target);
	}

	[Test]
	public void UnitType_EqualityTest5 ()
	{
		UnitType expected = null;
		UnitType target = null;

		Assert.IsTrue (expected == target);
	}

	[Test]
	public void UnitType_EqualityTest6 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Mass"];

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void UnitType_EqualityTest7 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = null;

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void UnitType_EqualityTest8 ()
	{
		UnitType expected = null;
		UnitType target = unitPro.UnitTypes ["Length"];

		Assert.IsTrue (expected != target);
	}

	[Test]
	public void UnitType_EqualityTest8_1 ()
	{
		UnitType expected = null;
		UnitType target = null;

		Assert.IsFalse (expected != target);
	}

	[Test]
	public void UnitType_EqualityTest9 ()
	{
		UnitType expected = unitPro.UnitTypes ["Mass"];
		UnitType target = unitPro.UnitTypes ["Length"];

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void UnitType_EqualityTest10 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Length"];

		Assert.IsTrue (expected.Equals (target));
	}

	[Test]
	public void UnitType_EqualityTest11 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Mass"];

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void UnitType_EqualityTest12 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = null;

		Assert.IsFalse (expected.Equals (target));
	}

	[Test]
	public void UnitType_EqualityTest13 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Length"];

		Assert.IsTrue (expected.Equals ((object)target));
	}

	[Test]
	public void UnitType_EqualityTest14 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = unitPro.UnitTypes ["Mass"];

		Assert.IsFalse (expected.Equals ((object)target));
	}

	[Test]
	public void UnitType_EqualityTest154 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];
		UnitType target = null;

		Assert.IsFalse (expected.Equals ((object)target));
	}

	[Test]
	public void UnitType_EqualityTest15 ()
	{
		UnitType expected = unitPro.UnitTypes ["Length"];

		Assert.IsTrue (expected.GetHashCode () == expected.Name.GetHashCode ());
	}
	#endregion
}