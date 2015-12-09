using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWords.ConsoleApp;

namespace ReverseWords.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void HelloWorldReturnsWorldHello()
        {
            string input = "Hello World";
            string expected = "World Hello";

            string result = StringProcessor.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GeneralSubmissionGuidelineReturnsGuidelineSubmissionGeneral()
        {
            string input = "General Submission Guideline";
            string expected = "Guideline Submission General";

            string result = StringProcessor.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BaboonReturnsBaboon()
        {
            string input = "Baboon";
            string expected = "Baboon";

            string result = StringProcessor.ReverseWords(input);

            Assert.AreEqual(expected, result);
        }
    }
}
