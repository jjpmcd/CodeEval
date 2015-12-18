using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfPrimes.ConsoleApp;

namespace SumOfPrimes.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsFalseFor1()
        {
            //Arrange
            const int candidate = 1;

            //Act
            bool result = PrimeProcessor.IsPrime(candidate);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ReturnsTrueFor2()
        {
            //Arrange
            const int candidate = 2;

            //Act
            bool result = PrimeProcessor.IsPrime(candidate);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ReturnsTrueFor3()
        {
            //Arrange
            const int candidate = 3;

            //Act
            bool result = PrimeProcessor.IsPrime(candidate);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ReturnsFalseFor4()
        {
            //Arrange
            const int candidate = 4;

            //Act
            bool result = PrimeProcessor.IsPrime(candidate);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ReturnsTrueFor5()
        {
            //Arrange
            const int candidate = 5;

            //Act
            bool result = PrimeProcessor.IsPrime(candidate);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SumOfFirst1000PrimeNumbersEquals3682913()
        {
            //Arrange
            const int limit = 1000;
            const int expected = 3682913;

            //Act
            int result = PrimeProcessor.GetSumOfPrimes(limit);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
