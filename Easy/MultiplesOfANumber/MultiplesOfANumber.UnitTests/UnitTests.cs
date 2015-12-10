using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplesOfANumber.ConsoleApp;

namespace MultiplesOfANumber.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void XEquals13AndNEquals8Returns16()
        {
            string input = "13,8";
            int expected = 16;

            int result = MultipleProcessor.FindSmallestMultiple(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void XEquals17AndNEquals16Returns32()
        {
            string input = "17,16";
            int expected = 32;

            int result = MultipleProcessor.FindSmallestMultiple(input);

            Assert.AreEqual(expected, result);
        }
    }
}
