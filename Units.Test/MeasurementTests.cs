using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Units;

///<summary>
///This is a test class for MeasurementTest and is intended
///to contain all MeasurementTest Unit Tests
///</summary>
[TestClass()]
public class MeasurementTests
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

    #region "Measurement.Value"
    ///<summary>
    ///A test for Value
    ///</summary>
    [TestMethod()]
    public void MeasurementValueTest()
    {
        double expected = 10;
        Measurement target = new Measurement(expected, "ft");
        double actual = 0;
        actual = target.Value;

        Assert.AreEqual<double>(expected, actual);
    }
    #endregion

    #region "Measurement.Unit"
    ///<summary>
    ///A test for Unit
    ///</summary>
    [TestMethod()]
    public void MeasurementUnitTest()
    {
        Unit expected = unitPro.Units["Feet"];
        Measurement target = new Measurement(10, "ft");
        Unit actual = default(Unit);
        actual = target.Unit;

        Assert.AreEqual<string>(expected.Name, actual.Name);
    }
    #endregion

    #region "Measurement.Symbol"
    ///<summary>
    ///A test for Symbol
    ///</summary>
    [TestMethod()]
    public void MeasurementSymbolTest()
    {
        string expected = "ft";
        Measurement target = new Measurement(10, expected);
        string actual = null;
        actual = target.Symbol;

        Assert.AreEqual<string>(expected, actual);
    }

    [TestMethod()]
    public void MeasurementSymbolNullTest()
    {
        string expected = null;
        Measurement target = new Measurement(10, expected);
        string actual = null;
        actual = target.Symbol;

    }
    #endregion

    #region "Measurement.IsValid"
    ///<summary>
    ///A test for IsValid
    ///</summary>
    [TestMethod()]
    public void MeasurementIsValidTest()
    {
        bool expected = true;
        Measurement target = new Measurement(10, "ft");
        bool actual = false;
        actual = target.IsValid;

        Assert.AreEqual<bool>(expected, actual);
    }

    [TestMethod()]
    public void MeasurementIsValidNullTest()
    {
        bool expected = false;
        Measurement target = new Measurement(null);
        bool actual = false;
        actual = target.IsValid;

        Assert.AreEqual<bool>(expected, actual);
    }

    //[TestMethod()]
    //public void MeasurementIsValidNullTest2()
    //{
    //    bool expected = false;
    //    Measurement target = null;
    //    bool actual = false;
    //    actual = target.IsValid;

    //    Assert.AreEqual<bool>(expected, actual);
    //    Assert.IsTrue(target == null);
    //    Assert.IsFalse(target != null);
    //}

    [TestMethod()]
    public void MeasurementIsValidBadUnitTest()
    {
        bool expected = false;
        Measurement target = new Measurement(10, "ft", Result.BadUnit);
        bool actual = false;
        actual = target.IsValid;

        Assert.AreEqual<bool>(expected, actual);
    }
    #endregion

    #region "Measurement.FullValue"
    ///<summary>
    ///A test for FullValue
    ///</summary>
    [TestMethod()]
    public void MeasurementFullValueTest()
    {
        string expected = "10ft";
        Measurement target = new Measurement(10, "ft");
        string actual = null;
        actual = target.FullValue;

        Assert.AreEqual<string>(expected, actual);
    }

    //<TestMethod()> _
    //Public Sub MeasurementFullValueNullTest()
    //    Dim expected As String = "10"
    //    Dim target As Measurement = New Measurement(10, DirectCast(Nothing, String))
    //    Dim actual As String
    //    actual = target.FullValue

    //    Assert.AreEqual(Of String)(expected, actual)
    //End Sub
    #endregion

    #region "Measurement.Flags"
    ///<summary>
    ///A test for Flags
    ///</summary>
    [TestMethod()]
    public void MeasurementFlagsTest()
    {
        Measurement target = new Measurement(10, "ft");
        MeasurementFlags expected = MeasurementFlags.UseMaxBound;
        MeasurementFlags actual = default(MeasurementFlags);
        target.Flags = expected;
        actual = target.Flags;
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Converter"
    ///<summary>
    ///A test for Converter
    ///</summary>
    [TestMethod()]
    public void MeasurementConverterTest()
    {
        Measurement target = new Measurement(10, "ft");
        UnitConverter actual = default(UnitConverter);
        actual = target.Converter;

        Assert.IsNotNull(actual);
    }
    #endregion

    #region "Measurement.ConversionResult"
    ///<summary>
    ///A test for ConversionResult
    ///</summary>
    [TestMethod()]
    public void MeasurementConversionResultTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result expected = Result.GroupNotFound;
        Result actual = default(Result);
        target.ConversionResult = expected;
        actual = target.ConversionResult;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementConversionResultNullTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result expected = Result.NoError;
        Result actual = default(Result);
        target.ConversionResult = Result.NoError;
        actual = target.ConversionResult;

        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.ValidateEntry(Value,Symbol)"
    ///<summary>
    ///A test for ValidateEntry
    ///</summary>
    [TestMethod()]
    public void MeasurementValidateEntryValueSymbolTest()
    {
        Measurement target = new Measurement(10, "ft");
        double value = 100;
        string symbol = "in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.ValidateEntry(value, symbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntryValueSymbolIncompatibleTest()
    {
        Measurement target = new Measurement(10, "ft");
        double value = 100;
        string symbol = "hr";
        Result expected = Result.UnitMismatch;
        Result actual = default(Result);
        actual = target.ValidateEntry(value, symbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntryValueSymbolMaxTest()
    {
        Measurement target = new Measurement(10, "ft");
        target.SetMaxBound(100, "ft");
        target.Flags = MeasurementFlags.UseMaxBound;
        double value = 200;
        string symbol = "ft";
        Result expected = Result.ValueTooHigh;
        Result actual = default(Result);
        actual = target.ValidateEntry(value, symbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntryValueSymbolMinTest()
    {
        Measurement target = new Measurement(10, "ft");
        target.SetMinBound(5, "ft");
        target.Flags = MeasurementFlags.UseMinBound;
        double value = 1;
        string symbol = "ft";
        Result expected = Result.ValueTooLow;
        Result actual = default(Result);
        actual = target.ValidateEntry(value, symbol);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.ValidateEntry(entry)"
    ///<summary>
    ///A test for ValidateEntry
    ///</summary>
    [TestMethod()]
    public void MeasurementValidateEntrySymbolTest()
    {
        Measurement target = new Measurement(10, "ft");
        string entry = "100in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.ValidateEntry(entry);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntrySymbolIncompatibleTest()
    {
        Measurement target = new Measurement(10, "ft");
        string entry = "100hr";
        Result expected = Result.UnitMismatch;
        Result actual = default(Result);
        actual = target.ValidateEntry(entry);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntrySymbolMaxTest()
    {
        Measurement target = new Measurement(10, "ft");
        target.SetMaxBound(100, "ft");
        target.Flags = MeasurementFlags.UseMaxBound;
        string entry = "200ft";
        Result expected = Result.ValueTooHigh;
        Result actual = default(Result);
        actual = target.ValidateEntry(entry);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementValidateEntrySymbolMinTest()
    {
        Measurement target = new Measurement(10, "ft");
        target.SetMinBound(5, "ft");
        target.Flags = MeasurementFlags.UseMinBound;
        string entry = "1ft";
        Result expected = Result.ValueTooLow;
        Result actual = default(Result);
        actual = target.ValidateEntry(entry);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.ToString"
    ///<summary>
    ///A test for ToString
    ///</summary>
    [TestMethod()]
    public void MeasurementToStringTest()
    {
        Measurement target = new Measurement(10, "ft");
        string expected = "10ft";
        string actual = null;
        actual = target.ToString();
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.SetValue(measurementString)"
    ///<summary>
    ///A test for SetValue
    ///</summary>
    [TestMethod()]
    public void MeasurementSetValueStringTest()
    {
        Measurement target = new Measurement("ft");
        string measurement = "10ft";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetValue(measurement);
        Assert.AreEqual(expected, actual);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementSetValueStringTest2()
    {
        Measurement target = new Measurement("ft");
        string measurement = "12in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetValue(measurement);
        Assert.AreEqual(expected, actual);
        Assert.AreEqual<double>(12, target.Value);
    }

    [TestMethod()]
    public void MeasurementSetValueStringTest3()
    {
        Measurement target = new Measurement("ft");
        target.Flags = MeasurementFlags.ForceUnit;
        string measurement = "12in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetValue(measurement);
        Assert.AreEqual(expected, actual);
        Assert.AreEqual<double>(1, target.Value);
    }

    [TestMethod()]
    public void MeasurementSetValueStringInvalidTest()
    {
        Measurement target = new Measurement("ft");
        string measurement = "12hr";
        Result expected = Result.UnitMismatch;
        Result actual = default(Result);
        actual = target.SetValue(measurement);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetValueStringNullTest()
    {
        Measurement target = new Measurement("ft");
        Result actual = default(Result);
        actual = target.SetValue((string)null);
        Assert.Fail();
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetValueStringEmptyTest()
    {
        Measurement target = new Measurement("ft");
        Result actual = default(Result);
        actual = target.SetValue(string.Empty);
        Assert.Fail();
    }
    #endregion

    #region "Measurement.SetValue(value)"
    ///<summary>
    ///A test for SetValue
    ///</summary>
    [TestMethod()]
    public void MeasurementSetValueTest()
    {
        Measurement target = new Measurement("ft");
        double value = 15;
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetValue(value);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.SetUnit(symbol)"
    ///<summary>
    ///A test for SetUnit
    ///</summary>
    [TestMethod()]
    public void MeasurementSetUnitTest()
    {
        Measurement target = new Measurement("ft");
        string unitSymbol = "s";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetUnit(unitSymbol);
        Assert.AreEqual(expected, actual);
        Assert.AreEqual("Second", target.Unit.Name);
    }

    [TestMethod()]
    public void MeasurementSetUnitTest2()
    {
        Measurement target = new Measurement("ft");
        string unitSymbol = "ft";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetUnit(unitSymbol);
        Assert.AreEqual(expected, actual);
        Assert.AreEqual("Feet", target.Unit.Name);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetUnitNullTest()
    {
        Measurement target = new Measurement("ft");
        Result expected = Result.BadUnit;
        Result actual = default(Result);
        actual = target.SetUnit(null);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetUnitEmptyTest()
    {
        Measurement target = new Measurement("ft");
        Result expected = Result.BadUnit;
        Result actual = default(Result);
        actual = target.SetUnit(string.Empty);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.SetMinBound"
    ///<summary>
    ///A test for SetMinBound
    ///</summary>
    [TestMethod()]
    public void MeasurementSetMinBoundTest()
    {
        Measurement target = new Measurement(10, "ft");
        double minbound = 0;
        string unitSymbol = "ft";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetMinBound(minbound, unitSymbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementSetMinBoundTest2()
    {
        Measurement target = new Measurement(10, "ft");
        double minbound = 12;
        string unitSymbol = "in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetMinBound(minbound, unitSymbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetMinBoundNullTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result actual;
        actual = target.SetMinBound(0, null);
        Assert.Fail();
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetMinBoundEmptyTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result actual = default(Result);
        actual = target.SetMinBound(1, string.Empty);
        Assert.Fail();
    }
    #endregion

    #region "Measurement.SetMaxBound"
    ///<summary>
    ///A test for SetMinBound
    ///</summary>
    [TestMethod()]
    public void MeasurementSetMaxBoundTest()
    {
        Measurement target = new Measurement(10, "ft");
        double maxbound = 100;
        string unitSymbol = "ft";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetMaxBound(maxbound, unitSymbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementSetMaxBoundTest2()
    {
        Measurement target = new Measurement(10, "ft");
        double maxbound = 8;
        string unitSymbol = "in";
        Result expected = Result.NoError;
        Result actual = default(Result);
        actual = target.SetMaxBound(maxbound, unitSymbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetMaxBoundNullTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result actual = default(Result);
        actual = target.SetMinBound(0, null);
        Assert.Fail();
    }

    [TestMethod()]
    [ExpectedException(typeof(ArgumentNullException))]
    public void MeasurementSetMaxBoundEmptyTest()
    {
        Measurement target = new Measurement(10, "ft");
        Result actual = default(Result);
        actual = target.SetMinBound(1, string.Empty);
        Assert.Fail();
    }
    #endregion

    #region "Measurement.Operator -"
    ///<summary>
    ///A test for op_Subtraction
    ///</summary>
    [TestMethod()]
    public void Measurementop_SubtractionTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(5, "ft");
        Measurement expected = new Measurement(0, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 - d2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_SubtractionDiffUnitTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(60, "in");
        Measurement expected = new Measurement(0, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 - d2);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator *"
    ///<summary>
    ///A test for op_Multiply
    ///</summary>
    [TestMethod()]
    public void Measurementop_MultiplyTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(5, "ft");
        Measurement expected = new Measurement(25, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 * d2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_MultiplyDiffUnitTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(60, "in");
        Measurement expected = new Measurement(25, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 * d2);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator <="
    ///<summary>
    ///A test for op_LessThanOrEqual
    ///</summary>
    [TestMethod()]
    public void Measurementop_LessThanOrEqualTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(6, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanOrEqualTest2()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanOrEqualFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanOrEqualDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(600, "in");
        bool expected = true;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanOrEqualDiffUnitTest2()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = true;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanOrEqualFalseDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "in");
        bool expected = false;
        bool actual = false;
        actual = (left <= right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator <"
    ///<summary>
    ///A test for op_LessThan
    ///</summary>
    [TestMethod()]
    public void Measurementop_LessThanTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(6, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left < right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left < right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(400, "in");
        bool expected = true;
        bool actual = false;
        actual = (left < right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_LessThanFalseDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = false;
        bool actual = false;
        actual = (left < right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator <>"
    ///<summary>
    ///A test for op_Inequality
    ///</summary>
    [TestMethod()]
    public void Measurementop_InequalityTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left != right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_InequalityFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left != right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_InequalityDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "in");
        bool expected = true;
        bool actual = false;
        actual = (left != right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_InequalityDiffUnitFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = false;
        bool actual = false;
        actual = (left != right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator >="
    ///<summary>
    ///A test for op_GreaterThanOrEqual
    ///</summary>
    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualTest2()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(6, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "in");
        bool expected = true;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualDiffUnitTest2()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = true;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanOrEqualDiffUnitFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(600, "in");
        bool expected = false;
        bool actual = false;
        actual = (left >= right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator >"
    ///<summary>
    ///A test for op_GreaterThan
    ///</summary>
    [TestMethod()]
    public void Measurementop_GreaterThanTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left > right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left > right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "in");
        bool expected = true;
        bool actual = false;
        actual = (left > right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_GreaterThanDiffUnitFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = false;
        bool actual = false;
        actual = (left > right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator ="
    ///<summary>
    ///A test for op_Equality
    ///</summary>
    [TestMethod()]
    public void Measurementop_EqualityTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(5, "ft");
        bool expected = true;
        bool actual = false;
        actual = (left == right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_EqualityDiffUnitTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(60, "in");
        bool expected = true;
        bool actual = false;
        actual = (left == right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_EqualityFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(4, "ft");
        bool expected = false;
        bool actual = false;
        actual = (left == right);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_EqualityDiffUnitFalseTest()
    {
        Measurement left = new Measurement(5, "ft");
        Measurement right = new Measurement(61, "in");
        bool expected = false;
        bool actual = false;
        actual = (left == right);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator /"
    ///<summary>
    ///A test for op_Division
    ///</summary>
    [TestMethod()]
    public void Measurementop_DivisionTest()
    {
        Measurement d1 = new Measurement(25, "ft");
        Measurement d2 = new Measurement(5, "ft");
        Measurement expected = new Measurement(5, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 / d2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_DivisionDiffUnitTest()
    {
        Measurement d1 = new Measurement(25, "ft");
        Measurement d2 = new Measurement(60, "in");
        Measurement expected = new Measurement(5, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 / d2);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Operator +"
    ///<summary>
    ///A test for op_Addition
    ///</summary>
    [TestMethod()]
    public void Measurementop_AdditionTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(5, "ft");
        Measurement expected = new Measurement(10, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 + d2);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Measurementop_AdditionDiffUnitTest()
    {
        Measurement d1 = new Measurement(5, "ft");
        Measurement d2 = new Measurement(60, "in");
        Measurement expected = new Measurement(10, "ft");
        Measurement actual = default(Measurement);
        actual = (d1 + d2);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.GetValueAs(unitSymbol)"
    ///<summary>
    ///A test for GetValueAs
    ///</summary>
    //[TestMethod()]
    //public void MeasurementGetValueAsTest()
    //{
    //    Measurement target = new Measurement(5, "ft");
    //    string unitSymbol = "in";
    //    Measurement expected = new Measurement(Convert.ToDecimal("60.0000"), "in");
    //    Measurement actual = default(Measurement);
    //    actual = target.GetValueAs(unitSymbol);
    //    Assert.AreEqual(expected.Value, actual.Value);
    //    Assert.AreEqual(expected.ToString, actual.ToString);
    //}

    [TestMethod()]
    public void MeasurementGetValueAsInvalidUnitSymbolTest()
    {
        Measurement target = new Measurement(5, "ft");
        string unitSymbol = "F";
        Measurement actual = default(Measurement);
        actual = target.GetValueAs(unitSymbol);

        Assert.IsTrue(actual.ConversionResult == Result.UnitMismatch);
        Assert.IsTrue(actual.Value == 0);
        Assert.IsTrue(actual.Value == 0);
    }
    #endregion

    #region "Measurement.GetStringValueAs(unitSymbol)"
    ///<summary>
    ///A test for GetStringValueAs
    ///</summary>
    [TestMethod()]
    public void MeasurementGetStringValueAsTest()
    {
        Measurement target = new Measurement(5, "ft");
        string unitSymbol = "in";
        string expected = "60in";
        string actual = null;
        actual = target.GetStringValueAs(unitSymbol);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementGetStringValueAsInvalidUnitSymbolTest()
    {
        Measurement target = new Measurement(10, "ft");
        string unitSymbol = "F";
        string expected = "Conversion Error";
        string actual = null;
        actual = target.GetStringValueAs(unitSymbol);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.GetHashCode"
    ///<summary>
    ///A test for GetHashCode
    ///</summary>
    [TestMethod()]
    public void MeasurementGetHashCodeTest()
    {
        Measurement target = new Measurement(10, "ft");

        Measurement Mes = target.Converter.ConvertUnits(target.Value, target.Unit.DefaultSymbol, "m");

        string expectedStr = null;

        if (Mes.ConversionResult != Result.NoError)
        {
            expectedStr = target.Value.ToString() + "|" + target.ConversionResult.ToString();
        }
        else
        {
            expectedStr = Mes.Value.ToString() + "|" + Mes.Symbol;
        }

        int expected = (expectedStr).GetHashCode();
        int actual = 0;
        actual = target.GetHashCode();
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Equals(Of Measurement)"
    ///<summary>
    ///A test for Equals
    ///</summary>
    [TestMethod()]
    public void MeasurementEqualsOfTest()
    {
        IEquatable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(60, "in");
        bool expected = true;
        bool actual = false;
        actual = target.Equals(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsOfTest2()
    {
        IEquatable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(5, "ft");
        bool expected = true;
        bool actual = false;
        actual = target.Equals(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsOfFalseTest()
    {
        IEquatable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(5, "in");
        bool expected = false;
        bool actual = false;
        actual = target.Equals(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsOfInvalidUnitTest()
    {
        IEquatable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(5, "F");
        bool expected = false;
        bool actual = false;
        actual = target.Equals(other);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Equals(obj)"
    ///<summary>
    ///A test for Equals
    ///</summary>
    [TestMethod()]
    public void MeasurementEqualsTest()
    {
        Measurement target = new Measurement(5, "ft");
        object obj = new Measurement(5, "ft");
        bool expected = true;
        bool actual = false;
        actual = target.Equals(obj);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsTest2()
    {
        Measurement target = new Measurement(5, "ft");
        object obj = new Measurement(60, "in");
        bool expected = true;
        bool actual = false;
        actual = target.Equals(obj);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsFalseTest()
    {
        Measurement target = new Measurement(5, "ft");
        object obj = new Measurement(5, "in");
        bool expected = false;
        bool actual = false;
        actual = target.Equals(obj);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsInvalidTest()
    {
        Measurement target = new Measurement(5, "ft");
        object obj = new Measurement(5, "F");
        bool expected = false;
        bool actual = false;
        actual = target.Equals(obj);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementEqualsInvalidTypeTest()
    {
        Measurement target = new Measurement(5, "ft");
        object obj = 5;
        bool expected = false;
        bool actual = false;
        actual = target.Equals(obj);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.CompareTo"
    ///<summary>
    ///A test for CompareTo
    ///</summary>
    [TestMethod()]
    public void MeasurementCompareToTest()
    {
        IComparable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(5, "ft");
        int expected = 0;
        int actual = 0;
        actual = target.CompareTo(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementCompareToGreaterTest()
    {
        IComparable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(4, "ft");
        int expected = 1;
        int actual = 0;
        actual = target.CompareTo(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementCompareToGreaterDifferentUnitTest()
    {
        IComparable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(41, "in");
        int expected = 1;
        int actual;
        actual = target.CompareTo(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementCompareToLessTest()
    {
        IComparable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(6, "ft");
        int expected = -1;
        int actual = 0;
        actual = target.CompareTo(other);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MeasurementCompareToGreaterLessUnitTest()
    {
        IComparable<Measurement> target = new Measurement(5, "ft");
        Measurement other = new Measurement(61, "in");
        int expected = -1;
        int actual = 0;
        actual = target.CompareTo(other);
        Assert.AreEqual(expected, actual);
    }
    #endregion

    #region "Measurement.Measurement(Value, UnitSymbol)"
    ///<summary>
    ///A test for Measurement Constructor
    ///</summary>
    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolTest()
    {
        double value = 10;
        string unitSymbol = "ft";
        Measurement target = new Measurement(value, unitSymbol);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolNullNullTest()
    {
        Measurement target = new Measurement(0, (string)null);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.BadUnit);
        Assert.AreEqual<Unit>(null, target.Unit);
        Assert.AreEqual<double>(0, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolValueNullTest()
    {
        Measurement target = new Measurement(0, "ft");

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(0, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolUnitSymbolNullTest()
    {
        Measurement target = new Measurement(10, (string)null);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.BadUnit);
        Assert.AreEqual<Unit>(null, target.Unit);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolEmptyTest()
    {
        Measurement target = new Measurement(10, string.Empty);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.BadUnit);
        Assert.AreEqual<Unit>(null, target.Unit);
        Assert.AreEqual<double>(10, target.Value);
    }
    #endregion

    #region "Measurement.Measurement(unitSymbol)"
    ///<summary>
    ///A test for Measurement Constructor
    ///</summary>
    [TestMethod()]
    public void MeasurementConstructorUnitSymbolTest()
    {
        string unitSymbol = "ft";
        Measurement target = new Measurement(unitSymbol);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(0, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorUnitSymbolNullTest()
    {
        Measurement target = new Measurement(null);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.BadUnit);
        Assert.AreEqual<Unit>(null, target.Unit);
        Assert.AreEqual<double>(0, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorUnitSymbolEmptyTest()
    {
        Measurement target = new Measurement(null);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.BadUnit);
        Assert.AreEqual<Unit>(null, target.Unit);
        Assert.AreEqual<double>(0, target.Value);
    }
    #endregion

    #region "Measurement.Measurement(Value, UnitSymbol, ConversionResult)"
    ///<summary>
    ///A test for Measurement Constructor
    ///</summary>
    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolResultTest()
    {
        double value = 10;
        string unitSymbol = "ft";
        Result ConversionResult = Result.NoError;
        Measurement target = new Measurement(value, unitSymbol, ConversionResult);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitSymbolResultTest2()
    {
        double value = 10;
        string unitSymbol = "ft";
        Result ConversionResult = Result.GenericError;
        Measurement target = new Measurement(value, unitSymbol, ConversionResult);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.GenericError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(10, target.Value);
    }
    #endregion

    #region "Measurement.Measurement(Value,Unit,ConversionResult)"
    ///<summary>
    ///A test for Measurement Constructor
    ///</summary>
    [TestMethod()]
    public void MeasurementConstructorValueUnitConversionResultTest()
    {
        double value = 10;
        Unit unit = unitPro.Units["Feet"];
        Result ConversionResult = Result.NoError;
        Measurement target = new Measurement(value, unit, ConversionResult);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.AreEqual<string>("Feet", target.Unit.Name);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueUnitConversionResultNullTest()
    {
        Measurement target = new Measurement(0, (Unit)null, Result.NoError);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.IsNull(target.Unit);
        Assert.AreEqual<double>(0, target.Value);
    }
    #endregion

    #region "Measurement.Measurement(Value,Result)"
    ///<summary>
    ///A test for Measurement Constructor
    ///</summary>
    [TestMethod()]
    public void MeasurementConstructorValueResultTest()
    {
        double value = 10;
        Result ConversionResult = Result.NoError;
        Measurement target = new Measurement(value, ConversionResult);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.IsNull(target.Unit);
        Assert.AreEqual<double>(10, target.Value);
    }

    [TestMethod()]
    public void MeasurementConstructorValueResultNullTest()
    {
        Measurement target = new Measurement(0, Result.NoError);

        Assert.IsNotNull(target);
        Assert.IsTrue(target.Flags == MeasurementFlags.None);
        Assert.IsTrue(target.ConversionResult == Result.NoError);
        Assert.IsNull(target.Unit);
        Assert.AreEqual<double>(0, target.Value);
    }
    #endregion
}

