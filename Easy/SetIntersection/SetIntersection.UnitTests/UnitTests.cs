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

        [TestMethod]
        public void TestMethod4()
        {
            string input = "95,96,97,98,99,100,101,102,103;60,61,62,63,64,65,66";
            string expected = "";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "76,77,78,79,80,81,82,83,84,85;72,73,74,75,76,77,78,79,80,81,82,83,84,85";
            string expected = "76,77,78,79,80,81,82,83,84,85";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string input = "92,93,94,95,96,97,98,99,100,101,102;94,95,96,97,98,99,100,101,102,103,104,105,106";
            string expected = "94,95,96,97,98,99,100,101,102";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string input = "20,25,36,45,89;25,36,77,88,98";
            string expected = "25,36";

            string result = SetComparer.GetIntersectingSet(input);

            Assert.AreEqual(expected, result);
        }
    }
}
