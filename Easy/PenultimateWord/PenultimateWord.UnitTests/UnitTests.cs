using Microsoft.VisualStudio.TestTools.UnitTesting;
using PenultimateWord.ConsoleApp;

namespace PenultimateWord.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "some line with text";
            string expected = "with";

            string result = Scanner.GetPenultimateWord(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "another line";
            string expected = "another";

            string result = Scanner.GetPenultimateWord(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "another";
            string expected = "another";

            string result = Scanner.GetPenultimateWord(input);

            Assert.AreEqual(expected, result);
        }
    }
}
