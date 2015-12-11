using System;
using BitPositions.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitPositions.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Bits2And3AreTheSameFor86()
        {
            string input = "86,2,3";

            bool result = BitChecker.AreEqualAtPositions(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Bits1And2AreNotTheSameFor125()
        {
            string input = "125,1,2";

            bool result = BitChecker.AreEqualAtPositions(input);

            Assert.IsFalse(result);
        }
    }
}