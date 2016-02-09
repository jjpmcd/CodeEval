using System;
using DataRecovery.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataRecovery.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "2000 and was not However, implemented 1998 it until;9 8 3 4 1 5 7 2";
            string expected = "However, it was not implemented until 1998 and 2000";

            string result = Reconstructor.GetSentence(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "programming first The language;3 2 1";
            string expected = "The first programming language";

            string result = Reconstructor.GetSentence(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "programs Manchester The written ran Mark 1952 1 in Autocode from;6 2 1 7 5 3 11 4 8 9";
            string expected = "The Manchester Mark 1 ran programs written in Autocode from 1952";

            string result = Reconstructor.GetSentence(input);

            Assert.AreEqual(expected, result);
        }
    }
}
