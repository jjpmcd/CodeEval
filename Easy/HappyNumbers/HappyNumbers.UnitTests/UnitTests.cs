using System;
using HappyNumbers.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyNumbers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Number1IsAHappyNumber()
        {
            string input = "1";
            string expected = "1";

            string result = HappinessChecker.IsHappy(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Number7IsAHappyNumber()
        {
            string input = "7";
            string expected = "1";

            string result = HappinessChecker.IsHappy(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Number22IsNotAHappyNumber()
        {
            string input = "22";
            string expected = "0";

            string result = HappinessChecker.IsHappy(input);

            Assert.AreEqual(expected, result);
        }
    }
}
