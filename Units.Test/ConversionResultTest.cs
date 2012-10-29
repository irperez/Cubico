using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

[TestClass()]
public class ConversionResultTest
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

    #region "ConversionResult.ConversionResult()"
    [TestMethod()]
    public void ConversionResultConstructorTest()
    {
        ConversionResult res = new ConversionResult();

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }
    #endregion

    #region "ConversionResult.ConversionResult(Double)"
    [TestMethod()]
    public void ConversionResultConstructorDoubleTest()
    {
        ConversionResult res = new ConversionResult(10.5);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(10.5, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleZeroTest()
    {
        ConversionResult res = new ConversionResult((double)0);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }
    #endregion

    #region "ConversionResult.ConversionResult(Double, String)"
    [TestMethod()]
    public void ConversionResultConstructorDoubleStringTest()
    {
        ConversionResult res = new ConversionResult(10.5, "lb");

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(10.5, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>("lb", res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleStringNullTest()
    {
        ConversionResult res = new ConversionResult(0, Convert.ToString(null));

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleStringNullTest2()
    {
        ConversionResult res = new ConversionResult(10.5, Convert.ToString(null));

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(10.5, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleStringZeroTest3()
    {
        ConversionResult res = new ConversionResult(0, "lb");

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>("lb", res.Symbol);
    }
    #endregion

    #region "ConversionResult.ConversionResult(Double, Result)"
    [TestMethod()]
    public void ConversionResultConstructorDoubleResultTest()
    {
        ConversionResult res = new ConversionResult(10.5, Result.GenericError);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(10.5, res.Value);
        Assert.AreEqual(Result.GenericError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleResultNullTest()
    {
        ConversionResult res = new ConversionResult(0, (Result)0);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleResultNullTest2()
    {
        ConversionResult res = new ConversionResult(10.5, (Result)0);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(10.5, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorDoubleResultNullTest3()
    {
        ConversionResult res = new ConversionResult(0, Result.GenericError);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.GenericError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }
    #endregion

    #region "ConversionResult.ConversionResult(Result)"
    [TestMethod()]
    public void ConversionResultConstructorResultTest()
    {
        ConversionResult res = new ConversionResult(Result.GenericError);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.GenericError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultConstructorResultNullTest()
    {
        ConversionResult res = new ConversionResult(0.0);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(0, res.Value);
        Assert.AreEqual(Result.NoError, res.Result);
        Assert.AreEqual<string>(null, res.Symbol);
    }
    #endregion

    #region "ConversionResult.Result"
    [TestMethod()]
    public void ConversionResultResultTest()
    {
        ConversionResult res = new ConversionResult(Result.GenericError);

        Assert.IsNotNull(res);
        Assert.AreEqual(Result.GenericError, res.Result);

        res.Result = Result.UnitNotFound;

        Assert.AreEqual(Result.UnitNotFound, res.Result);
    }

    [TestMethod()]
    public void ConversionResultResultNullTest()
    {
        ConversionResult res = new ConversionResult(Result.GenericError);

        Assert.IsNotNull(res);
        Assert.AreEqual(Result.GenericError, res.Result);

        res.Result = Result.NoError;

        Assert.AreEqual(Result.NoError, res.Result);
    }
    #endregion

    #region "ConversionResult.Value"
    [TestMethod()]
    public void ConversionResultValueTest()
    {
        ConversionResult res = new ConversionResult(12.1);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(12.1, res.Value);

        res.Value = 0.33;

        Assert.AreEqual<double>(0.33, res.Value);
    }

    [TestMethod()]
    public void ConversionResultValueNullTest()
    {
        ConversionResult res = new ConversionResult(12.1);

        Assert.IsNotNull(res);
        Assert.AreEqual<double>(12.1, res.Value);

        res.Value = 0.0;

        Assert.AreEqual<double>(0, res.Value);
    }
    #endregion

    #region "ConversionResult.Symbol"
    [TestMethod()]
    public void ConversionResultSymbolTest()
    {
        ConversionResult res = new ConversionResult(12.1, "ft");

        Assert.IsNotNull(res);
        Assert.AreEqual<string>("ft", res.Symbol);

        res.Symbol = "C";

        Assert.AreEqual<string>("C", res.Symbol);
    }

    [TestMethod()]
    public void ConversionResultSymbolNullTest()
    {
        ConversionResult res = new ConversionResult(12.1, "ft");

        Assert.IsNotNull(res);
        Assert.AreEqual<string>("ft", res.Symbol);

        res.Symbol = null;

        Assert.AreEqual<string>(null, res.Symbol);
    }
    #endregion
}

