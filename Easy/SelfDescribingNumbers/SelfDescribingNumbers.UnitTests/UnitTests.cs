using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelfDescribingNumbers.ConsoleApp;

namespace SelfDescribingNumbers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Number2020IsSelfDescribing()
        {
            var input = "2020";
            var expected = '1';

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Number22IsNotSelfDescribing()
        {
            var input = "22";
            var expected = '0';

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Number1210IsSelfDescribing()
        {
            var input = "1210";
            var expected = '1';

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
