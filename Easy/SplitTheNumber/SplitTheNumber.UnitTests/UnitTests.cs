using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SplitTheNumber.ConsoleApp;

namespace SplitTheNumber.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "3413289830 a-bcdefghij";
            int expected = -413289827;

            int result = Processor.GetSplitNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "776 a+bc";
            int expected = 83;

            int result = Processor.GetSplitNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "12345 a+bcde";
            int expected = 2346;

            int result = Processor.GetSplitNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "1232 ab+cd";
            int expected = 44;

            int result = Processor.GetSplitNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "90602 a+bcde";
            int expected = 611;

            int result = Processor.GetSplitNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
