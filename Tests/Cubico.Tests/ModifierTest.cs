using System;
using Cubico;
using NUnit.Framework;

namespace Cubico.Tests
{
	[TestFixture]
	public class ModifierTest
	{
		TestContext testContextInstance;
		// Gets or sets the test context which provides information about and functionality for the current test run.
		public TestContext TestContext {
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}
		#region "Modifier.Modifier()"
		[Test]
		public void ModifierNewTest ()
		{
			Modifier testObj = new Modifier ();

			Assert.IsNotNull (testObj);
			Assert.IsTrue (testObj.ID == 0);
			Assert.IsTrue (testObj.Value == 0);
			Assert.IsNull (testObj.ParentUnit);
		}
		#endregion
		#region "Modifier.ID"
		[Test]
		public void ModifierIDTest ()
		{
			Modifier testObj = new Modifier ();
			testObj.ID = 99;

			Assert.AreEqual (99, testObj.ID);
		}
		#endregion
		#region "Modifier.ParentUnit"
		[Test]
		public void ModifierParentUnitTest ()
		{
			Unit testUnitObj = new Unit {
				ID = 99,
				Name = "Name"
			};

			Modifier testObj = new Modifier ();
			testObj.ParentUnit = testUnitObj;

			Assert.IsNotNull (testObj.ParentUnit);
			Assert.AreEqual (testUnitObj.ID, testObj.ParentUnit.ID);
			Assert.AreEqual (testUnitObj.Name, testObj.ParentUnit.Name);
		}

		[Test]
		public void ModifierParentUnitNullTest ()
		{
			Modifier testObj = new Modifier ();
			testObj.ParentUnit = null;

			Assert.IsNull (testObj.ParentUnit);
		}
		#endregion
		#region "Modifier.Value"
		[Test]
		public void ModifierValueTest ()
		{
			Modifier testObj = new Modifier ();
			testObj.Value = Convert.ToDecimal (0.001);

			Assert.AreEqual (Convert.ToDecimal (0.001), testObj.Value);
		}
		#endregion
		#region "Modifier.Order"
		[Test]
		public void ModifierOrderTest ()
		{
			Modifier testObj = new Modifier ();
			testObj.Order = 10;

			Assert.AreEqual (10, testObj.Order);
		}
		#endregion
		#region "Modifier.ModifierType"
		[Test]
		public void ModifierTypeTest ()
		{
			Modifier testObj = new Modifier ();
			testObj.ModifierType = ModifierType.Multiply;

			Assert.AreEqual (ModifierType.Multiply, testObj.ModifierType);
		}
		#endregion
	}
}