using System; 
using System.Diagnostics.Contracts;
using Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

///<summary>
///This is a test class for UnitTest and is intended
///to contain all UnitTest Unit Tests
///</summary>
[TestClass()]
public class UnitTypeTest
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

    #region "UnitType.UnitType()"
    [TestMethod()]
    public void UnitTypeNewTest()
    {
        UnitType testObj = new UnitType();

        Assert.IsNotNull(testObj);
        Assert.IsTrue(testObj.ID == 0);
        Assert.IsNotNull(testObj.Units);
        Assert.IsTrue(testObj.Units.Count == 0);
        Assert.IsTrue(string.IsNullOrEmpty(testObj.Name));
    }
    #endregion

    #region "UnitType.ID"
    [TestMethod()]
    public void UnitTypeIDTest()
    {
        UnitType testObj = new UnitType();

        testObj.ID = 99;

        Assert.AreEqual<int>(99, testObj.ID);
    }

    //[TestMethod()]
    //public void UnitTypeIDNullTest()
    //{
    //    UnitType testObj = new UnitType();

    //    testObj.ID = null;

    //    Assert.AreEqual(null, testObj.ID);
    //}

    //[TestMethod()]
    //public void UnitTypeIDNegativeTest()
    //{
    //    UnitType testObj = new UnitType();

    //    testObj.ID = -1;

    //    Assert.IsTrue(testObj.ID == -1);

    //    List<ErrorInfo> data = Validation.DataAnnotationValidator.GetErrors(testObj).ToList;

    //    Assert.IsNotNull(data);
    //    Assert.IsTrue(data.Count > 0);
    //    Assert.IsTrue(data(0).PropertyName == "ID");
    //}
    #endregion

    #region "UnitType.Name"
    [TestMethod()]
    public void UnitTypeNameTest()
    {
        UnitType testObj = new UnitType();

        testObj.Name = "Test Name";

        Assert.AreEqual<string>("Test Name", testObj.Name);
    }

    //[TestMethod()]
    //public void UnitTypeNameNullTest()
    //{
    //    UnitType testObj = new UnitType();

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
    public void UnitType_EqualityTest()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Length"];

        Assert.IsTrue(expected == target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest2()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Mass"];

        Assert.IsFalse(expected == target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest3()
    {
        UnitType expected = null;
        UnitType target = unitPro.UnitTypes["Mass"];

        Assert.IsFalse(expected == target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest4()
    {
        UnitType expected = unitPro.UnitTypes["Mass"];
        UnitType target = null;

        Assert.IsFalse(expected == target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest5()
    {
        UnitType expected = null;
        UnitType target = null;

        Assert.IsTrue(expected == target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest6()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Mass"];

        Assert.IsTrue(expected != target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest7()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = null;

        Assert.IsTrue(expected != target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest8()
    {
        UnitType expected = null;
        UnitType target = unitPro.UnitTypes["Length"];

        Assert.IsTrue(expected != target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest8_1()
    {
        UnitType expected = null;
        UnitType target = null;

        Assert.IsFalse(expected != target);
    }

    [TestMethod()]
    public void UnitType_EqualityTest9()
    {
        UnitType expected = unitPro.UnitTypes["Mass"];
        UnitType target = unitPro.UnitTypes["Length"];

        Assert.IsFalse(expected.Equals(target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest10()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Length"];

        Assert.IsTrue(expected.Equals(target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest11()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Mass"];

        Assert.IsFalse(expected.Equals(target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest12()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = null;

        Assert.IsFalse(expected.Equals(target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest13()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Length"];

        Assert.IsTrue(expected.Equals((object)target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest14()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = unitPro.UnitTypes["Mass"];

        Assert.IsFalse(expected.Equals((object)target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest154()
    {
        UnitType expected = unitPro.UnitTypes["Length"];
        UnitType target = null;

        Assert.IsFalse(expected.Equals((object)target));
    }

    [TestMethod()]
    public void UnitType_EqualityTest15()
    {
        UnitType expected = unitPro.UnitTypes["Length"];

        Assert.IsTrue(expected.GetHashCode() == expected.Name.GetHashCode());
    }
    #endregion

    #region "Serialization"
    //[TestMethod()]
    //public void UnitType_BinarySerializationTest()
    //{
    //    UnitType expected = unitPro.UnitTypes["Length"];
    //    UnitType actual = default(UnitType);

    //    byte[] data = Utility.BinarySerialize(expected);
    //    actual = (UnitType)Utility.BinaryDeserialize(data);

    //    Assert.IsNotNull(actual);
    //    Assert.AreEqual(expected.ID, actual.ID);
    //    Assert.AreEqual(expected.Name, actual.Name);
    //    Assert.AreEqual(expected.Description, actual.Description);
    //    Assert.AreEqual(expected.Units.Count, actual.Units.Count);
    //}

    //[TestMethod()]
    //public void UnitType_DataContractSerializationTest()
    //{
    //    UnitType expected = unitPro.UnitTypes["Length"];
    //    UnitType actual = default(UnitType);

    //    string data = Utility.DataContractSerialize(expected);
    //    actual = (UnitType)Utility.DataContractDeserialize(data, typeof(UnitType));

    //    Assert.IsNotNull(actual);
    //    Assert.AreEqual(expected.ID, actual.ID);
    //    Assert.AreEqual(expected.Name, actual.Name);
    //    Assert.AreEqual(expected.Description, actual.Description);
    //    Assert.AreEqual(expected.Units.Count, actual.Units.Count);
    //}
    #endregion

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

