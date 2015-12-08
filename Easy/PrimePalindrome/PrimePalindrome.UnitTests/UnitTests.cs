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

        [TestMethod]
        public void TheNumber2IsPrime()
        {
            int input = 2;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber3IsPrime()
        {
            int input = 3;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber4IsNotPrime()
        {
            int input = 4;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber5IsPrime()
        {
            int input = 5;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber6IsNotPrime()
        {
            int input = 6;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber7IsPrime()
        {
            int input = 7;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber8IsNotPrime()
        {
            int input = 8;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber9IsNotPrime()
        {
            int input = 9;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber929IsPrime()
        {
            int input = 929;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheNumber1000IsNotPrime()
        {
            int input = 1000;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TheNumber2147483647IsPrime()
        {
            int input = 2147483647;
            var result = NumberProcessor.IsPrime(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TheLargestPrimePalindromeLessThan1000Equals929()
        {
            int input = 1000;
            int expected = 929;

            var result = NumberProcessor.FindLargestPrimePalindrome(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheLargestPrimePalindromeLessThan727Equals383()
        {
            int input = 727;
            int expected = 383;

            var result = NumberProcessor.FindLargestPrimePalindrome(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheLargestPrimePalindromeLessThan11Equals7()
        {
            int input = 11;
            int expected = 7;

            var result = NumberProcessor.FindLargestPrimePalindrome(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TheLargestPrimePalindromeLessThan2ReturnsNegative1()
        {
            int input = 2;
            int expected = -1;

            var result = NumberProcessor.FindLargestPrimePalindrome(input);
            Assert.AreEqual(expected, result);
        }
    }
}
