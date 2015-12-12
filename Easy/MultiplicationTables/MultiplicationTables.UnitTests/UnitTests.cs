using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationTables.ConsoleApp;

namespace MultiplicationTables.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FirstRow()
        {
            int input = 1;
            string expected = "1   2   3   4   5   6   7   8   9  10  11  12";

            string result = MultiplePrinter.PrintRow(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SecondRow()
        {
            int input = 2;
            string expected = "2   4   6   8  10  12  14  16  18  20  22  24";

            string result = MultiplePrinter.PrintRow(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ThirdRow()
        {
            int input = 3;
            string expected = "3   6   9  12  15  18  21  24  27  30  33  36";

            string result = MultiplePrinter.PrintRow(input);

            Assert.AreEqual(expected, result);
        }
    }
}
