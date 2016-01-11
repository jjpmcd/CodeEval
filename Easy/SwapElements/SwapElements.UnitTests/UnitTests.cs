using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapElements.ConsoleApp;

namespace SwapElements.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "1 2 3 4 5 6 7 8 9 : 0-8";
            string expected = "9 2 3 4 5 6 7 8 1";

            string result = Swapper.GetSwapped(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "1 2 3 4 5 6 7 8 9 10 : 0-1, 1-3";
            string expected = "2 4 3 1 5 6 7 8 9 10";

            string result = Swapper.GetSwapped(input);

            Assert.AreEqual(expected, result);
        }
    }
}
