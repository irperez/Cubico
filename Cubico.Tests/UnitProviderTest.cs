using System;
using System.Collections.Generic;
using NUnit.Framework;
using Cubico;

///<summary>
///This is a test class for UnitProvider and is intended
///to contain all UnitProvider Unit Tests
///</summary>
[TestClass()]
public class UnitProviderTest
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


    ///<summary>
    ///A test for UnitTypes
    ///</summary>
	[TestMethod()]
    public void UnitTypesTest ()
	{
		Dictionary<string, UnitType> actual = default(Dictionary<string, UnitType>);
		actual = unitPro.UnitTypes;

		Assert.IsNotNull (actual);
		Assert.IsTrue (actual.Count > 0);
	}
    ///<summary>
    ///A test for Units
    ///</summary>
	[TestMethod()]
    public void UnitsTest ()
	{
		Dictionary<string, Unit> actual = default(Dictionary<string, Unit>);
		actual = unitPro.Units;

		Assert.IsNotNull (actual);
		Assert.IsTrue (actual.Count > 0);
	}
    ///<summary>
    ///A test for Symbols
    ///</summary>
	[TestMethod()]
    public void SymbolsTest ()
	{
		Dictionary<string, Unit> actual = default(Dictionary<string, Unit>);
		actual = unitPro.Symbols;

		Assert.IsNotNull (actual);
		Assert.IsTrue (actual.Count > 0);
	}
}

