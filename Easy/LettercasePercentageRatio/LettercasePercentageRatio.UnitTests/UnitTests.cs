using System;
using LettercasePercentageRatio.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LettercasePercentageRatio.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "thisTHIS";
            string expected = "lowercase: 50.00 uppercase: 50.00";

            string result = Scanner.GetLettercasePercentages(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "AAbbCCDDEE";
            string expected = "lowercase: 20.00 uppercase: 80.00";

            string result = Scanner.GetLettercasePercentages(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "N";
            string expected = "lowercase: 0.00 uppercase: 100.00";

            string result = Scanner.GetLettercasePercentages(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "UkJ";
            string expected = "lowercase: 33.33 uppercase: 66.67";

            string result = Scanner.GetLettercasePercentages(input);

            Assert.AreEqual(expected, result);
        }
    }
}
