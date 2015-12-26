using FindAWriter.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindAWriter.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input =
                "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";
            string expected = "Stephen King 1947";

            string result = CodeCracker.GetWriter(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input =
                "3Kucdq9bfCEgZGF2nwx8UpzQJyHiOm0hoaYP6ST1WM7Nks5XjrR4IltBeDLV vA| 2 26 33 55 34 50 33 61 44 28 46 32 28 30 3 50 34 61 40 7 1 31";
            string expected = "Kyotaro Nishimura 1930";

            string result = CodeCracker.GetWriter(input);

            Assert.AreEqual(expected, result);
        }
    }
}
