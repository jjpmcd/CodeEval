using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfDigits.ConsoleApp;

namespace SumOfDigits.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SumOfDigits23Equals5()
        {
            string input = "23";
            int expected = 5;

            int result = DigitProcessor.SumOfDigits(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SumOfDigits496Equals19()
        {
            string input = "496";
            int expected = 19;

            int result = DigitProcessor.SumOfDigits(input);

            Assert.AreEqual(expected, result);
        }
    }
}
