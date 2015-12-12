using System;
using FibonacciSeries.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciSeries.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void The5thNumberInTheSeriesIs5()
        {
            string input = "5";
            int expected = 5;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The12thNumberInTheSeriesIs144()
        {
            string input = "12";
            int expected = 144;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The0thNumberInTheSeriesIs0()
        {
            string input = "0";
            int expected = 0;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The1stNumberInTheSeriesIs1()
        {
            string input = "1";
            int expected = 1;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The2ndNumberInTheSeriesIs1()
        {
            string input = "2";
            int expected = 1;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The3rdNumberInTheSeriesIs2()
        {
            string input = "3";
            int expected = 2;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void The4thNumberInTheSeriesIs3()
        {
            string input = "4";
            int expected = 3;

            int result = FibonacciGenerator.GetNthNumber(input);

            Assert.AreEqual(expected, result);
        }
    }
}
