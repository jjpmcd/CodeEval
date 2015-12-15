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
            var input = 1;

            var result = HappinessChecker.IsHappy(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Number7IsAHappyNumber()
        {
            var input = 7;

            var result = HappinessChecker.IsHappy(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Number22IsNotAHappyNumber()
        {
            var input = 22;

            var result = HappinessChecker.IsHappy(input);

            Assert.IsFalse(result);
        }
    }
}
