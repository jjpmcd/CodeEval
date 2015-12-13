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

        [TestMethod]
        public void TestMethod3()
        {
            string input = "2,2,2,2,2";
            string expected = "2";

            string result = StringProcessor.GetUniqueElements(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "13,13,13,14,15,15,16,16,17,17,18";
            string expected = "13,14,15,16,17,18";

            string result = StringProcessor.GetUniqueElements(input);

            Assert.AreEqual(expected, result);
        }
    }
}
