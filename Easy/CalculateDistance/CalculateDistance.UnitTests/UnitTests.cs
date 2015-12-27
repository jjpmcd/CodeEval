using CalculateDistance.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateDistance.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "(25, 4) (1, -6)";
            int expected = 26;

            int result = Calculator.GetDistance(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "(47, 43) (-25, -11)";
            int expected = 90;

            int result = Calculator.GetDistance(input);

            Assert.AreEqual(expected, result);
        }
    }
}
