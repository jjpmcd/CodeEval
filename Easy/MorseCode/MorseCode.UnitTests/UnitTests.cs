using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCode.ConsoleApp;

namespace MorseCode.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = ".- ...- ..--- .-- .... .. . -.-. -..-  ....- .....";
            string expected = "AV2WHIECX 45";

            string result = Morser.GetDecodedMessage(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "-... .... ...--";
            string expected = "BH3";

            string result = Morser.GetDecodedMessage(input);

            Assert.AreEqual(expected, result);
        }
    }
}
