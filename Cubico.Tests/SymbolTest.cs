using System;
using System.Diagnostics.Contracts;
using Cubico;
using NUnit.Framework;

namespace Cubico.Tests
{
	///This is a test class for UnitTest and is intended to contain all UnitTest Unit Tests
	[TestClass()]
	public class SymbolTest
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

		#region "Symbol.Symbol()"
		[TestMethod()]
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
		[TestMethod()]
		[ExpectedException(typeof(ArgumentNullException))]
		public void SymbolNewEfUnitSymbolUnitNullTest ()
		{
			Symbol testObj = new Symbol (null);

			Assert.Fail ("Null values are not allowed for this constructor.");
		}

		[TestMethod()]
		public void SymbolNewEfUnitSymbolUnitTest ()
		{
			Unit unitObj = new Unit {
				ID = 99,
				Name = "Name"
			};
			Symbol testObj = new Symbol (unitObj);

			Assert.IsNotNull (testObj);

			Assert.IsTrue (string.IsNullOrEmpty(testObj.Value));

			Assert.IsNotNull (testObj.Unit);
			Assert.IsTrue (testObj.Unit.ID == unitObj.ID);
		}
		#endregion

		#region "Symbol.ID"
		//[TestMethod()]
		//public void SymbolIDNullTest()
		//{
		//    Symbol testObj = new Symbol();

		//    testObj.Id = null;

		//    Assert.AreEqual<int>(null, testObj.Id);
		//}

		//[TestMethod()]
		//public void SymbolIDNegativeTest()
		//{
		//    Symbol testObj = new Symbol();

		//    testObj.Id = -1;

		//    Assert.IsTrue(testObj.Id == -1);

		//    List<ErrorInfo> data = Validation.DataAnnotationValidator.GetErrors(testObj).ToList;

		//    Assert.IsNotNull(data);
		//    Assert.IsTrue(data.Count > 0);
		//    Assert.IsTrue(data[0].PropertyName == "ID");
		//}

		[TestMethod()]
		public void SymbolIDTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Id = 99;

			Assert.AreEqual<int> (99, testObj.Id);
		}
		#endregion

		#region "Symbol.ParentUnit"
		[TestMethod()]
		public void SymbolParentUnitTest ()
		{
			Unit testUnitObj = new Unit ();
			Symbol testObj = new Symbol (testUnitObj);



			testObj.Unit = testUnitObj;

			Assert.IsNotNull (testObj.Unit);
			Assert.AreEqual<int> (testUnitObj.ID, testObj.Unit.ID);
			Assert.AreEqual<string> (testUnitObj.Name, testObj.Unit.Name);
		}

		[TestMethod()]
		public void SymbolParentUnitNullTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Unit = null;

			Assert.IsNull (testObj.Unit);
		}
		#endregion

		#region "Symbol.Value"
		[TestMethod()]
		public void SymbolValueTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.Value = "Test Name";

			Assert.AreEqual<string> ("Test Name", testObj.Value);
		}
		//[TestMethod()]
		//public void SymbolValueNullTest()
		//{
		//    Symbol testObj = new Symbol();

		//    testObj.Value = null;

		//    Assert.IsTrue(string.IsNullOrWhiteSpace(testObj.Value));

		//    List<ErrorInfo> data = Validation.DataAnnotationValidator.GetErrors(testObj).ToList;

		//    Assert.IsNotNull(data);
		//    Assert.IsTrue(data.Count > 0);
		//    Assert.IsTrue(data[0].PropertyName == "Value");
		//}
		#endregion

		#region "Symbol.IsDefault"
		[TestMethod()]
		public void SymbolIsDefaultTest ()
		{
			Symbol testObj = new Symbol ();

			testObj.IsDefault = true;

			Assert.AreEqual<bool> (true, testObj.IsDefault);
		}
		#endregion

		#region "IEquatable"
		[TestMethod()]
		public void Symbol_EqualityTest ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected == target);
		}

		[TestMethod()]
		public void Unit_EqualityTest2 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected == target);
		}

		[TestMethod()]
		public void Unit_EqualityTest3 ()
		{
			Symbol expected = null;
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected == target);
		}

		[TestMethod()]
		public void Unit_EqualityTest4 ()
		{
			Symbol expected = unitPro.Symbols ["in"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected == target);
		}

		[TestMethod()]
		public void Unit_EqualityTest5 ()
		{
			Symbol expected = null;
			Symbol target = null;

			Assert.IsTrue (expected == target);
		}

		[TestMethod()]
		public void Unit_EqualityTest6 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsTrue (expected != target);
		}

		[TestMethod()]
		public void Unit_EqualityTest7 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsTrue (expected != target);
		}

		[TestMethod()]
		public void Unit_EqualityTest8 ()
		{
			Symbol expected = null;
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected != target);
		}

		[TestMethod()]
		public void Unit_EqualityTest8_1 ()
		{
			Symbol expected = null;
			Symbol target = null;

			Assert.IsFalse (expected != target);
		}

		[TestMethod()]
		public void Unit_EqualityTest9 ()
		{
			Symbol expected = unitPro.Symbols ["in"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsFalse (expected.Equals(target));
		}

		[TestMethod()]
		public void Unit_EqualityTest10 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.Equals(target));
		}

		[TestMethod()]
		public void Unit_EqualityTest11 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected.Equals(target));
		}

		[TestMethod()]
		public void Unit_EqualityTest12 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected.Equals(target));
		}

		[TestMethod()]
		public void Unit_EqualityTest13 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.Equals((object)target));
		}

		[TestMethod()]
		public void Unit_EqualityTest14 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = unitPro.Symbols ["in"].Symbols [0];

			Assert.IsFalse (expected.Equals((object)target));
		}

		[TestMethod()]
		public void Unit_EqualityTest154 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];
			Symbol target = null;

			Assert.IsFalse (expected.Equals((object)target));
		}

		[TestMethod()]
		public void Unit_EqualityTest15 ()
		{
			Symbol expected = unitPro.Symbols ["ft"].Symbols [0];

			Assert.IsTrue (expected.GetHashCode() == expected.Value.GetHashCode());
		}
		#endregion

		#region "Serialization"
		//[TestMethod()]
		//public void Unit_BinarySerializationTest()
		//{
		//    Symbol expected = unitPro.Symbols["ft"].Symbols[0];
		//    Symbol actual = default(Symbol);

		//    byte[] data = Utility.BinarySerialize(expected);
		//    actual = (Symbol)Utility.BinaryDeserialize(data);

		//    Assert.IsNotNull(actual);
		//    Assert.AreEqual(expected.Id, actual.Id);
		//    Assert.AreEqual(expected.Value, actual.Value);
		//    Assert.AreEqual(expected.IsDefault, actual.IsDefault);
		//    Assert.AreEqual(expected.UnitId, actual.UnitId);
		//}

		//[TestMethod()]
		//public void Unit_DataContractSerializationTest()
		//{
		//    Symbol expected = unitPro.Symbols["ft"].Symbols[0];
		//    Symbol actual = default(Symbol);

		//    string data = Utility.DataContractSerialize(expected);
		//    actual = (Symbol)Utility.DataContractDeserialize(data, typeof(Symbol));

		//    Assert.IsNotNull(actual);
		//    Assert.AreEqual(expected.Id, actual.Id);
		//    Assert.AreEqual(expected.Value, actual.Value);
		//    Assert.AreEqual(expected.IsDefault, actual.IsDefault);
		//    Assert.AreEqual(expected.UnitId, actual.UnitId);
		//}
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

		//Dim efSymbolsymbolObj As New EFUnitSymbol
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
}