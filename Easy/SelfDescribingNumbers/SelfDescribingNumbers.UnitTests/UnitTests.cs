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

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Number22IsNotSelfDescribing()
        {
            var input = "22";

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Number1210IsSelfDescribing()
        {
            var input = "1210";

            var result = Numberifier.IsSelfDescribingNumber(input);

            Assert.IsTrue(result);
        }
    }
}
