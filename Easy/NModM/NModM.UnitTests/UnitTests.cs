using Microsoft.VisualStudio.TestTools.UnitTesting;
using NModM.ConsoleApp;

namespace NModM.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "20,6";
            int expected = 2;

            int result = Calculator.GetRemainder(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "2,3";
            int expected = 2;

            int result = Calculator.GetRemainder(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "10,3";
            int expected = 1;

            int result = Calculator.GetRemainder(input);

            Assert.AreEqual(expected, result);
        }
    }
}
