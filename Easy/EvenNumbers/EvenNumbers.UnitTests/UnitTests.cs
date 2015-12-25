using EvenNumbers.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvenNumbers.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "701";

            bool result = Checker.IsEven(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "4123";

            bool result = Checker.IsEven(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "2936";

            bool result = Checker.IsEven(input);

            Assert.IsTrue(result);
        }
    }
}
