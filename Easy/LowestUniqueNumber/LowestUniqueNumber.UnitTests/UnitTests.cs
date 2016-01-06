using System;
using LowestUniqueNumber.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LowestUniqueNumber.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "3 3 9 1 6 5 8 1 5 3";
            int expected = 5;

            int result = NumberGame.GetLowestUnique(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "9 2 9 9 1 8 8 8 2 1 1";
            int expected = 0;

            int result = NumberGame.GetLowestUnique(input);

            Assert.AreEqual(expected, result);
        }
    }
}
