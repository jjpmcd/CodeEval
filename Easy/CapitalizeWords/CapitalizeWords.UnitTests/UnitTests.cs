using CapitalizeWords.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalizeWords.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Hello world";
            string expected = "Hello World";

            string result = Caser.ToTitleCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "javaScript language";
            string expected = "JavaScript Language";

            string result = Caser.ToTitleCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "a letter";
            string expected = "A Letter";

            string result = Caser.ToTitleCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "1st thing";
            string expected = "1st Thing";

            string result = Caser.ToTitleCase(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "thing";
            string expected = "Thing";

            string result = Caser.ToTitleCase(input);

            Assert.AreEqual(expected, result);
        }
    }
}
