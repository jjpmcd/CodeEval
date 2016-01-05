using System;
using JsonMenuIds.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JsonMenuIds.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input =
                "{\"menu\": {\"header\": \"menu\", \"items\": [{\"id\": 27}, {\"id\": 0, \"label\": \"Label 0\"}, null, {\"id\": 93}, {\"id\": 85}, {\"id\": 54}, null, {\"id\": 46, \"label\": \"Label 46\"}]}}";
            int expected = 46;

            int result = JsonParser.GetSum(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "{\"menu\": {\"header\": \"menu\", \"items\": [{\"id\": 81}]}}";
            int expected = 0;

            int result = JsonParser.GetSum(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "{\"menu\": {\"header\": \"menu\", \"items\": [{\"id\": 70, \"label\": \"Label 70\"}, {\"id\": 85, \"label\": \"Label 85\"}, {\"id\": 93, \"label\": \"Label 93\"}, {\"id\": 2}]}}";
            int expected = 248;

            int result = JsonParser.GetSum(input);

            Assert.AreEqual(expected, result);
        }
    }
}
