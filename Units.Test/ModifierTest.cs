using System;
using System.Diagnostics.Contracts;
using Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

///<summary>
///This is a test class for UnitTest and is intended
///to contain all UnitTest Unit Tests
///</summary>
[TestClass()]
public class ModifierTest
{


    private TestContext testContextInstance;
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

    #region "Modifier.Modifier()"
    [TestMethod()]
    public void ModifierNewTest()
    {
        Modifier testObj = new Modifier();

        Assert.IsNotNull(testObj);
        Assert.IsTrue(testObj.ID == 0);
        Assert.IsTrue(testObj.Value == 0);
        Assert.IsNull(testObj.ParentUnit);
    }
    #endregion

    #region "Modifier.ID"
    [TestMethod()]
    public void ModifierIDTest()
    {
        Modifier testObj = new Modifier();

        testObj.ID = 99;

        Assert.AreEqual<int>(99, testObj.ID);
    }
    #endregion

    #region "Modifier.ParentUnit"
    [TestMethod()]
    public void ModifierParentUnitTest()
    {
        Unit testUnitObj = new Unit
        {
            ID = 99,
            Name = "Name"
        };
        Modifier testObj = new Modifier();

        testObj.ParentUnit = testUnitObj;

        Assert.IsNotNull(testObj.ParentUnit);
        Assert.AreEqual<int>(testUnitObj.ID, testObj.ParentUnit.ID);
        Assert.AreEqual<string>(testUnitObj.Name, testObj.ParentUnit.Name);
    }

    [TestMethod()]
    public void ModifierParentUnitNullTest()
    {
        Modifier testObj = new Modifier();

        testObj.ParentUnit = null;

        Assert.IsNull(testObj.ParentUnit);
    }
    #endregion

    #region "Modifier.Value"
    [TestMethod()]
    public void ModifierValueTest()
    {
        Modifier testObj = new Modifier();

        testObj.Value = Convert.ToDecimal(0.001);

        Assert.AreEqual<decimal>(Convert.ToDecimal(0.001), testObj.Value);
    }
    #endregion

    #region "Modifier.Order"
    [TestMethod()]
    public void ModifierOrderTest()
    {
        Modifier testObj = new Modifier();

        testObj.Order = 10;

        Assert.AreEqual<int>(10, testObj.Order);
    }


    #endregion

    #region "Modifier.ModifierType"
    [TestMethod()]
    public void ModifierTypeTest()
    {
        Modifier testObj = new Modifier();

        testObj.ModifierType = ModifierType.Multiply;

        Assert.AreEqual<ModifierType>(ModifierType.Multiply, testObj.ModifierType);
    }
    #endregion

    //Private Function InitEfObjects() As EFUnit
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

    //Return efUnitObj
    //End Function

}

