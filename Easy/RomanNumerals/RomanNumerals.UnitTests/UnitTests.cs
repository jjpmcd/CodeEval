using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.ConsoleApp;

namespace RomanNumerals.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string input = "159";
            string expected = "CLIX";

            //Act
            string result = Converter.ToRomanNumerals(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string input = "296";
            string expected = "CCXCVI";

            //Act
            string result = Converter.ToRomanNumerals(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string input = "3992";
            string expected = "MMMCMXCII";

            //Act
            string result = Converter.ToRomanNumerals(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
