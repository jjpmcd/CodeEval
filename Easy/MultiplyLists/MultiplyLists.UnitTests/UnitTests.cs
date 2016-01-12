using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplyLists.ConsoleApp;

namespace MultiplyLists.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "9 0 6 | 15 14 9";
            string expected = "135 0 54";

            string result = Calculator.MultiplyLists(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "5 | 8";
            string expected = "40";

            string result = Calculator.MultiplyLists(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "13 4 15 1 15 5 | 1 4 15 14 8 2";
            string expected = "13 16 225 14 120 10";

            string result = Calculator.MultiplyLists(input);

            Assert.AreEqual(expected, result);
        }
    }
}
