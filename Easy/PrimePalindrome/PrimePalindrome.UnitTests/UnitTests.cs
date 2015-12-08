using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimePalindrome.ConsoleApp;

namespace PrimePalindrome.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TheNumber929IsAPalindrome()
        {
            int input = 929;
            var result = NumberProcessor.IsPalindrome(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber1000IsNotAPalindrome()
        {
            int input = 1000;
            var result = NumberProcessor.IsPalindrome(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber11IsAPalindrome()
        {
            int input = 11;
            var result = NumberProcessor.IsPalindrome(input);
            Assert.IsTrue(result);
        }
    }
}
