using System;
using ArmstrongNumbers.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArmstrongNumbers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "6";

            bool result = NumberParser.IsArmstrongNumber(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "153";

            bool result = NumberParser.IsArmstrongNumber(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "351";

            bool result = NumberParser.IsArmstrongNumber(input);

            Assert.IsFalse(result);
        }
    }
}
