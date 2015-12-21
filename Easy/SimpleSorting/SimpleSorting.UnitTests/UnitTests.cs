using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleSorting.ConsoleApp;

namespace SimpleSorting.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "70.920 -38.797 14.354 99.323 90.374 7.581";
            string expected = "-38.797 7.581 14.354 70.920 90.374 99.323";

            string result = Sorter.SimpleSort(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "-37.507 -3.263 40.079 27.999 65.213 -55.552";
            string expected = "-55.552 -37.507 -3.263 27.999 40.079 65.213";

            string result = Sorter.SimpleSort(input);

            Assert.AreEqual(expected, result);
        }
    }
}
