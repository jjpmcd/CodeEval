using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RightmostChar.ConsoleApp;

namespace RightmostChar.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = "Hello World,r";
            var expected = 8;

            var result = StringProcessor.RightmostChar(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = "Hello CodeEval,E";
            var expected = 10;

            var result = StringProcessor.RightmostChar(input);

            Assert.AreEqual(expected, result);
        }
    }
}
