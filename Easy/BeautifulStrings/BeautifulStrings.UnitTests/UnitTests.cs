using System;
using BeautifulStrings.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeautifulStrings.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "ABbCcc";
            int expected = 152;

            int result = Beautifier.GetMaxBeauty(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Good luck in the Facebook Hacker Cup this year!";
            int expected = 754;

            int result = Beautifier.GetMaxBeauty(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "Ignore punctuation, please :)";
            int expected = 491;

            int result = Beautifier.GetMaxBeauty(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "Sometimes test cases are hard to make up.";
            int expected = 729;

            int result = Beautifier.GetMaxBeauty(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "So I just go consult Professor Dalves";
            int expected = 646;

            int result = Beautifier.GetMaxBeauty(input);

            Assert.AreEqual(expected, result);
        }
    }
}
