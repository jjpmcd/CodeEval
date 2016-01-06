using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveCharacters.ConsoleApp;

namespace RemoveCharacters.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = "how are you, abc";
            var expected = "how re you";

            //Act
            string result = Scrubber.RemoveCharacters(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var input = "hello world, def";
            var expected = "hllo worl";

            //Act
            string result = Scrubber.RemoveCharacters(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
