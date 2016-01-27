using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingChars.ConsoleApp;

namespace RacingChars.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input =      "#########_##";
            string expected =   "#########|##";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Racer.IndexOfPreviousManoeuvre = 9;
            string input =      "########C_##";
            string expected =   "########/_##";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Racer.IndexOfPreviousManoeuvre = 8;
            string input =      "#######_####";
            string expected =   "#######/####";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Racer.IndexOfPreviousManoeuvre = 7;
            string input =      "######_#C###";
            string expected =  @"######_#\###";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Racer.IndexOfPreviousManoeuvre = 8;
            string input =      "#######_C###";
            string expected =   "#######_|###";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Racer.IndexOfPreviousManoeuvre = 8;
            string input =      "#######_####";
            string expected =   "#######/####";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Racer.IndexOfPreviousManoeuvre = 7;
            string input =      "######C#_###";
            string expected =   "######/#_###";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Racer.IndexOfPreviousManoeuvre = 6;
            string input =      "######C_####";
            string expected =   "######|_####";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Racer.IndexOfPreviousManoeuvre = 6;
            string input =      "#######_####";
            string expected =  @"#######\####";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Racer.IndexOfPreviousManoeuvre = 7;
            string input =      "#######_####";
            string expected =   "#######|####";

            string result = Racer.GetNextManoeuvre(input);

            Assert.AreEqual(expected, result);
        }
    }
}
