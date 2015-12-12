using Lowercase.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lowercase.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "HELLO CODEEVAL";
            string expected = "hello codeeval";

            string result = CaseConverter.ToLowercase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "This is some text";
            string expected = "this is some text";

            string result = CaseConverter.ToLowercase(input);

            Assert.AreEqual(expected, result);
        }
    }
}
