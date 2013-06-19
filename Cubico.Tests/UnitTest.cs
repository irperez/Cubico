using System;
using System.Diagnostics.Contracts;
using Cubico;
using NUnit.Framework;
using System.Collections.ObjectModel;

///<summary>
///This is a test class for UnitTest and is intended
///to contain all UnitTest Unit Tests
///</summary>
[TestClass()]
public class UnitTest
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
    //<ClassInitialize()>  _
    //Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    //End Sub
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //<ClassCleanup()>  _
    //Public Shared Sub MyClassCleanup()
    //End Sub
    //
    //Use TestInitialize to run code before running each test
    //<TestInitialize()>  _
    //Public Sub MyTestInitialize()
    //End Sub
    //
    //Use TestCleanup to run code after each test has run
    //<TestCleanup()>  _
    //Public Sub MyTestCleanup()
    //End Sub
    //
    #endregion

    #region "Unit.Unit()"
	[TestMethod()]
    public void UnitNewTest ()
	{
		Unit testObj = new Unit ();

		Assert.IsNotNull (testObj);
		Assert.IsTrue (testObj.ID == 0);
		Assert.IsTrue (string.IsNullOrEmpty(testObj.DefaultSymbol));
		Assert.IsNull (testObj.UnitType);
		Assert.IsNotNull (testObj.Symbols);
		Assert.IsTrue (testObj.Symbols.Count == 0);
		Assert.IsNotNull (testObj.Modifiers);
		Assert.IsTrue (testObj.Modifiers.Count == 0);
		Assert.IsTrue (string.IsNullOrEmpty(testObj.Name));
	}
    #endregion

    #region "Unit.Unit(UnitType)"
	[TestMethod()]
	[ExpectedException(typeof(ArgumentNullException))]
	public void UnitNewEfUnitUnitTypeNullTest ()
	{
		Unit testObj = new Unit (null);

		Assert.Fail ("Constructor should cause a ContractException.  Nulls are not allowed");
	}

	[TestMethod()]
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
		Assert.AreEqual<string> (testunittype.Name, testObj.UnitType.Name);

		Assert.IsNotNull (testObj.Symbols);
		Assert.IsTrue (testObj.Symbols.Count == 0);

		Assert.IsNotNull (testObj.Modifiers);
		Assert.IsTrue (testObj.Modifiers.Count == 0);
		// Assert.IsTrue(testUnit.UnitModifiers(0).Value = testObj.Modifiers(0).Value)
	}
    #endregion

    #region "Unit.ParentType"
	[TestMethod()]
    public void UnitParentTypeTest ()
	{
		UnitType testUnitType = new UnitType {
			ID = 99,
			Name = "Name"
		};

		Unit testObj = new Unit ();

		testObj.UnitType = testUnitType;

		Assert.IsNotNull (testObj.UnitType);
		Assert.AreEqual<int> (testUnitType.ID, testObj.UnitType.ID);
		Assert.AreEqual<string> (testUnitType.Name, testObj.UnitType.Name);
	}

	[TestMethod()]
    public void UnitParentTypeNullTest ()
	{
		Unit testObj = new Unit ();

		testObj.UnitType = null;

		Assert.IsNull (testObj.UnitType);
	}
    #endregion

    #region "Unit.ID"
	[TestMethod()]
    public void UnitIDTest ()
	{
		Unit testObj = new Unit ();

		testObj.ID = 99;

		Assert.AreEqual<int> (99, testObj.ID);
	}
    //[TestMethod()]
    //public void UnitIDNullTest()
    //{
    //    Unit testObj = new Unit();

    //    testObj.ID = null;

    //    Assert.AreEqual(null, testObj.ID);
    //}

    //[TestMethod()]
    //public void UnitIDNegativeTest()
    //{
    //    Unit testObj = new Unit();

    //    testObj.ID = -1;

    //    Assert.IsTrue(testObj.ID == -1);

    //    List<ErrorInfo> data = Validation.DataAnnotationValidator.GetErrors(testObj).ToList;

    //    Assert.IsNotNull(data);
    //    Assert.IsTrue(data.Count > 0);
    //    Assert.IsTrue(data(0).PropertyName == "ID");
    //}
    #endregion

    #region "Unit.Name"
	[TestMethod()]
    public void UnitNameTest ()
	{
		Unit testObj = new Unit ();

		testObj.Name = "Test Name";

		Assert.AreEqual<string> ("Test Name", testObj.Name);
	}
    //[TestMethod()]
    //public void UnitNameNullTest()
    //{
    //    Unit testObj = new Unit();

    //    testObj.Name = null;

    //    Assert.IsTrue(string.IsNullOrWhiteSpace(testObj.Name));

    //    List<ErrorInfo> data = Validation.DataAnnotationValidator.GetErrors(testObj).ToList;

    //    Assert.IsNotNull(data);
    //    Assert.IsTrue(data.Count > 0);
    //    Assert.IsTrue(data(0).PropertyName == "Name");
    //}
    #endregion

    #region "IEquatable"
	[TestMethod()]
    public void Unit_EqualityTest ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected == target);
	}

	[TestMethod()]
    public void Unit_EqualityTest2 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected == target);
	}

	[TestMethod()]
    public void Unit_EqualityTest3 ()
	{
		Unit expected = null;
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected == target);
	}

	[TestMethod()]
    public void Unit_EqualityTest4 ()
	{
		Unit expected = unitPro.Units ["Inch"];
		Unit target = null;

		Assert.IsFalse (expected == target);
	}

	[TestMethod()]
    public void Unit_EqualityTest5 ()
	{
		Unit expected = null;
		Unit target = null;

		Assert.IsTrue (expected == target);
	}

	[TestMethod()]
    public void Unit_EqualityTest6 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsTrue (expected != target);
	}

	[TestMethod()]
    public void Unit_EqualityTest7 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsTrue (expected != target);
	}

	[TestMethod()]
    public void Unit_EqualityTest8 ()
	{
		Unit expected = null;
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected != target);
	}

	[TestMethod()]
    public void Unit_EqualityTest8_1 ()
	{
		Unit expected = null;
		Unit target = null;

		Assert.IsFalse (expected != target);
	}

	[TestMethod()]
    public void Unit_EqualityTest9 ()
	{
		Unit expected = unitPro.Units ["Inch"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsFalse (expected.Equals(target));
	}

	[TestMethod()]
    public void Unit_EqualityTest10 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.Equals(target));
	}

	[TestMethod()]
    public void Unit_EqualityTest11 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected.Equals(target));
	}

	[TestMethod()]
    public void Unit_EqualityTest12 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsFalse (expected.Equals(target));
	}

	[TestMethod()]
    public void Unit_EqualityTest13 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.Equals((object)target));
	}

	[TestMethod()]
    public void Unit_EqualityTest14 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = unitPro.Units ["Inch"];

		Assert.IsFalse (expected.Equals((object)target));
	}

	[TestMethod()]
    public void Unit_EqualityTest154 ()
	{
		Unit expected = unitPro.Units ["Feet"];
		Unit target = null;

		Assert.IsFalse (expected.Equals((object)target));
	}

	[TestMethod()]
    public void Unit_EqualityTest15 ()
	{
		Unit expected = unitPro.Units ["Feet"];

		Assert.IsTrue (expected.GetHashCode() == expected.Name.GetHashCode());
	}
    #endregion

    //#region "Serialization"
    //[TestMethod()]
    //public void Unit_BinarySerializationTest()
    //{
    //    Unit expected = unitPro.Units["Feet"];
    //    Unit actual = default(Unit);

    //    byte[] data = Utility.BinarySerialize(expected);
    //    actual = (Unit)Utility.BinaryDeserialize(data);

    //    Assert.IsNotNull(actual);
    //    Assert.AreEqual(expected.ID, actual.ID);
    //    Assert.AreEqual(expected.Name, actual.Name);
    //    Assert.AreEqual(expected.DefaultSymbol, actual.DefaultSymbol);
    //    Assert.AreEqual(expected.IsDefault, actual.IsDefault);
    //    Assert.AreEqual(expected.Modifiers.Count, actual.Modifiers.Count);
    //    Assert.AreEqual(expected.Symbols.Count, actual.Symbols.Count);
    //    Assert.AreEqual(expected.UnitTypeID, actual.UnitTypeID);
    //}

    //[TestMethod()]
    //public void Unit_DataContractSerializationTest()
    //{
    //    Unit expected = unitPro.Units["Feet"];
    //    Unit actual = default(Unit);

    //    string data = Utility.DataContractSerialize(expected);
    //    actual = (Unit)Utility.DataContractDeserialize(data, typeof(Unit));

    //    Assert.IsNotNull(actual);
    //    Assert.AreEqual(expected.ID, actual.ID);
    //    Assert.AreEqual(expected.Name, actual.Name);
    //    Assert.AreEqual(expected.DefaultSymbol, actual.DefaultSymbol);
    //    Assert.AreEqual(expected.IsDefault, actual.IsDefault);
    //    Assert.AreEqual(expected.Modifiers.Count, actual.Modifiers.Count);
    //    Assert.AreEqual(expected.Symbols.Count, actual.Symbols.Count);
    //    Assert.AreEqual(expected.UnitTypeID, actual.UnitTypeID);
    //}
    //#endregion

    //Private Function InitEfObjects() As EFUnitType
    //Dim efUnitTypeObj As New EFUnitType
    //efUnitTypeObj.ID = 10
    //efUnitTypeObj.Name = "Test Type"
    //efUnitTypeObj.Description = "Test Desc"

    //Dim efUnitObj As New EFUnit
    //efUnitObj.ID = 2
    //efUnitObj.Name = "Test Unit"
    //efUnitObj.UnitType = efUnitTypeObj

    //Dim efUnitModifierObj As New EFUnitModifier
    //efUnitModifierObj.ID = 2
    //efUnitModifierObj.ModifierID = 2
    //efUnitModifierObj.Order = 1
    //efUnitModifierObj.Value = 0.5

    //Dim efUnitSymbolObj As New EFUnitSymbol
    //efUnitSymbolObj.ID = 3
    //efUnitSymbolObj.IsDefault = True
    //efUnitSymbolObj.Symbol = "Tst"

    //efUnitModifierObj.Unit = efUnitObj
    //efUnitSymbolObj.Unit = efUnitObj

    //efUnitTypeObj.Unit.Add(efUnitObj)
    //efUnitObj.UnitModifiers.Add(efUnitModifierObj)
    //efUnitObj.UnitSymbol.Add(efUnitSymbolObj)

    //Return efUnitTypeObj
    //End Function
}
