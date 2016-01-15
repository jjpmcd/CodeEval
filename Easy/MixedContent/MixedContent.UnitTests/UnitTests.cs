using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MixedContent.ConsoleApp;

namespace MixedContent.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "8,33,21,0,16,50,37,0,melon,7,apricot,peach,pineapple,17,21";
            string expected = "melon,apricot,peach,pineapple|8,33,21,0,16,50,37,0,7,17,21";

            string result = Sorter.GetSeparatedLists(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "24,13,14,43,41";
            string expected = "24,13,14,43,41";

            string result = Sorter.GetSeparatedLists(input);

            Assert.AreEqual(expected, result);
        }
    }
}
