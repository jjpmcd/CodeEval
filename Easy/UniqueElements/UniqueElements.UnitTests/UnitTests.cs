using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueElements.ConsoleApp;

namespace UniqueElements.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "1,1,1,2,2,3,3,4,4";
            string expected = "1,2,3,4";

            string result = StringProcessor.GetUniqueElements(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "2,3,4,5,5";
            string expected = "2,3,4,5";

            string result = StringProcessor.GetUniqueElements(input);

            Assert.AreEqual(expected, result);
        }
    }
}
