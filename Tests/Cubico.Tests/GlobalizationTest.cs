using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using NUnit.Framework;

namespace Cubico.Tests
{
    class GlobalizationTest
    {
        TestContext testContextInstance;        
        // Gets or sets the test context which provides information about and functionality for the current test run.
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [Test]
        public void GlobalizationGermanTest()
        {
            TestContext.Out.WriteLine("Cubico Start");
            var defaultCurrentThread1 = Thread.CurrentThread.CurrentCulture.Name; // DEFUALT en-US
            var defaultCurrentUICulture1 = Thread.CurrentThread.CurrentUICulture.Name;

            TestContext.Out.WriteLine("");
            TestContext.Out.WriteLine(">Cubico de-DE");
            var cultureInfo2 = new CultureInfo("de-DE"); // TO GERMAN
            Thread.CurrentThread.CurrentCulture = cultureInfo2;
            Thread.CurrentThread.CurrentUICulture = cultureInfo2;

            
            double doubleValue = Convert.ToDouble(2.2);
            TestContext.Out.WriteLine(">" + doubleValue); // SEE CONSOLE; 2,2 BECAUSE de-DE
            string currentUnitName = "in";
            string targetUnitName = "cm";              
            CubicoTestMethod(doubleValue, currentUnitName, targetUnitName);
            

            //Assert.IsNotNull(testObj);
            //Assert.IsTrue(testObj.ID == 0);
            //Assert.IsTrue(string.IsNullOrEmpty(testObj.DefaultSymbol));
            //Assert.IsNull(testObj.UnitType);
            //Assert.IsNotNull(testObj.Symbols);
            //Assert.IsTrue(testObj.Symbols.Count == 0);
            //Assert.IsNotNull(testObj.Modifiers);
            //Assert.IsTrue(testObj.Modifiers.Count == 0);
            //Assert.IsTrue(string.IsNullOrEmpty(testObj.Name));
        }

        public void CubicoTestMethod(double _doubleValue, string _currentUnitName, string _targetUnitName)
        {
            
            UnitConverter target = new UnitConverter();
            var v1 = target.ConvertUnits(_doubleValue, _currentUnitName, _targetUnitName); // CURRENT, TARGET
            Assert.IsTrue(v1.IsValid);
            Assert.AreEqual("Centimetre", v1.Unit.Name);
            Assert.AreEqual(decimal.Parse("5.588", CultureInfo.InvariantCulture), Math.Round(v1.Value,3));
            TestContext.Out.WriteLine(">Console Success in " + Thread.CurrentThread.CurrentUICulture.Name);            
        }
    }
}



//using System;
//using System.Globalization;
//using System.Threading;

//namespace Ii.Ecommerce.WhiteBox
//{
//    class ClientProgram
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Cubico Start");
//            var defaultCurrentThread1 = Thread.CurrentThread.CurrentCulture.Name; // DEFUALT en-US
//            var defaultCurrentUICulture1 = Thread.CurrentThread.CurrentUICulture.Name;

//            // ----------------------------------------------------------------------  //
//            Console.WriteLine("");
//            Console.WriteLine(">Cubico de-DE");
//            var cultureInfo2 = new CultureInfo("de-DE"); // TO GERMAN
//            Thread.CurrentThread.CurrentCulture = cultureInfo2;
//            Thread.CurrentThread.CurrentUICulture = cultureInfo2;

//            try
//            {
//                double doubleValue = Convert.ToDouble(2.2);
//                Console.WriteLine(">" + doubleValue); // SEE CONSOLE; 2,2 BECAUSE de-DE
//                string currentUnitName = "in";
//                string targetUnitName = "cm";
//                TestCode testCode = new TestCode(); // TEST
//                testCode.CubicoMethod(doubleValue, currentUnitName, targetUnitName);
//            }
//            catch (Exception ex)
//            {
//                var message = ex.Message;
//            }

//            // ----------------------------------------------------------------------  //
//            Console.WriteLine("");
//            Console.WriteLine(">Cubico en-US");
//            var cultureInfo = new CultureInfo("en-US");
//            Thread.CurrentThread.CurrentCulture = cultureInfo;
//            Thread.CurrentThread.CurrentUICulture = cultureInfo;

//            try
//            {
//                double doubleValue = Convert.ToDouble(2.2);
//                Console.WriteLine(">" + doubleValue); // SEE CONSOLE; 2.2 BECAUSE en-US
//                string currentUnitName = "in";
//                string targetUnitName = "cm";
//                TestCode testCode = new TestCode(); // TEST
//                testCode.CubicoMethod(doubleValue, currentUnitName, targetUnitName);
//            }
//            catch (Exception ex)
//            {
//                var message = ex.Message;
//            }

//            Console.WriteLine("");
//            Console.WriteLine("Cubico Stop");
//            Console.ReadLine();
//        }
//    }
//    public class TestCode
//    {
//        public void CubicoMethod(double _doubleValue, string _currentUnitName, string _targetUnitName)
//        {
//            try
//            {
//                UnitConverter target = new UnitConverter();
//                var v1 = target.ConvertUnits(_doubleValue, _currentUnitName, _targetUnitName); // CURRENT, TARGET
//                Console.WriteLine(">Console Success in " + Thread.CurrentThread.CurrentUICulture.Name);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(">Console Error in " + Thread.CurrentThread.CurrentUICulture.Name);
//                var message = ex.Message;
//                throw; // GO BACK and CONTINUE
//            }
//        }
//    }
//}