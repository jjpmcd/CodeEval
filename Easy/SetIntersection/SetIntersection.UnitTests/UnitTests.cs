using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SetIntersection.ConsoleApp;

namespace SetIntersection.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "1,2,3,4;4,5,6";
            string expected = "4";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "20,21,22;45,46,47";
            string expected = "";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "7,8,9;8,9,10,11,12";
            string expected = "8,9";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }
    }
}
