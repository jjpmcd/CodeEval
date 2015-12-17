using System;
using HexToDecimal.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HexToDecimal.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "9f";
            int expected = 159;

            int result = BaseConverter.HexToDecimal(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "11";
            int expected = 17;

            int result = BaseConverter.HexToDecimal(input);

            Assert.AreEqual(expected, result);
        }
    }
}
