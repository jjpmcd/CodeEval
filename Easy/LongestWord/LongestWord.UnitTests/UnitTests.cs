using System;
using LongestWord.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LongestWord.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "some line with text";
            string expected = "some";

            string result = Parser.GetLongestWord(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "another line";
            string expected = "another";

            string result = Parser.GetLongestWord(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "another";
            string expected = "another";

            string result = Parser.GetLongestWord(input);

            Assert.AreEqual(expected, result);
        }
    }
}
