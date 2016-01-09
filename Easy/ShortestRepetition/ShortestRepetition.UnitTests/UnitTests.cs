using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestRepetition.ConsoleApp;

namespace ShortestRepetition.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "abcabcabcabc";
            int expected = 3;

            int result = Scanner.GetSmallestPeriod(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "bcbcbcbcbcbcbcbcbcbcbcbcbcbc";
            int expected = 2;

            int result = Scanner.GetSmallestPeriod(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "dddddddddddddddddddd";
            int expected = 1;

            int result = Scanner.GetSmallestPeriod(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "adcdefg";
            int expected = 7;

            int result = Scanner.GetSmallestPeriod(input);

            Assert.AreEqual(expected, result);
        }
    }
}
