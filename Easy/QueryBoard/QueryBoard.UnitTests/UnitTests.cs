using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryBoard.ConsoleApp;

namespace QueryBoard.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = @"SetCol 32 20
SetRow 15 7
SetRow 16 31
QueryCol 32";
            string expected = "5118";

            string result = TestHelper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = @"SetCol 32 20
SetRow 15 7
SetRow 16 31
QueryCol 32
SetCol 2 14
QueryRow 10";
            string expected = @"5118
34";

            string result = TestHelper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = @"SetCol 32 20
SetRow 15 7
SetRow 16 31
QueryCol 32
SetCol 2 14
QueryRow 10
SetCol 14 0
QueryRow 15";
            string expected = @"5118
34
1792";

            string result = TestHelper(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = @"SetCol 32 20
SetRow 15 7
SetRow 16 31
QueryCol 32
SetCol 2 14
QueryRow 10
SetCol 14 0
QueryRow 15
SetRow 10 1
QueryCol 2";
            string expected = @"5118
34
1792
3571";

            string result = TestHelper(input);

            Assert.AreEqual(expected, result);
        }

        public static string TestHelper(string lines)
        {
            var queryBoard = Board.GetNewBoard();
            var builder = new StringBuilder();
            var reader = new StringReader(lines);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var queryResult = Board.Query(line, queryBoard);
                if (queryResult == -1) continue;
                if (builder.Length != 0)
                {
                    builder.AppendLine();
                }
                builder.Append(queryResult);
            }

            return builder.ToString();
        }
    }
}
