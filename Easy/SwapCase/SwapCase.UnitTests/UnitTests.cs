using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapCase.ConsoleApp;

namespace SwapCase.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Hello world!";
            string expected = "hELLO WORLD!";

            string result = Swapper.SwapCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "JavaScript language 1.8";
            string expected = "jAVAsCRIPT LANGUAGE 1.8";

            string result = Swapper.SwapCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "A letter";
            string expected = "a LETTER";

            string result = Swapper.SwapCase(input);

            Assert.AreEqual(expected, result);
        }
    }
}
