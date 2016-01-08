using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordToDigit.ConsoleApp;

namespace WordToDigit.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "zero;two;five;seven;eight;four";
            string expected = "025784";

            string result = Parser.GetDigits(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "three;seven;eight;nine;two";
            string expected = "37892";

            string result = Parser.GetDigits(input);

            Assert.AreEqual(expected, result);
        }
    }
}
