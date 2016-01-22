using System;
using CompressedSequence.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompressedSequence.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "40 40 40 40 29 29 29 29 29 29 29 29 57 57 92 92 92 92 92 86 86 86 86 86 86 86 86 86 86";
            string expected = "4 40 8 29 2 57 5 92 10 86";

            string result = Dictator.GetCompressedSequence(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "73 73 73 73 41 41 41 41 41 41 41 41 41 41";
            string expected = "4 73 10 41";

            string result = Dictator.GetCompressedSequence(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "1 1 3 3 3 2 2 2 2 14 14 14 11 11 11 2";
            string expected = "2 1 3 3 4 2 3 14 3 11 1 2";

            string result = Dictator.GetCompressedSequence(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "7";
            string expected = "1 7";

            string result = Dictator.GetCompressedSequence(input);

            Assert.AreEqual(expected, result);
        }
    }
}
