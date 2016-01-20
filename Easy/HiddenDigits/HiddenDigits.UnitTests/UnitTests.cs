using System;
using HiddenDigits.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HiddenDigits.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "abcdefghik";
            string expected = "012345678";

            string result = Processor.GetAllDigits(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "Xa,}A#5N}{xOBwYBHIlH,#W";
            string expected = "05";

            string result = Processor.GetAllDigits(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "(ABW>'yy^'M{X-K}q,";
            string expected = "NONE";

            string result = Processor.GetAllDigits(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "6240488";
            string expected = "6240488";

            string result = Processor.GetAllDigits(input);

            Assert.AreEqual(expected, result);
        }
    }
}
