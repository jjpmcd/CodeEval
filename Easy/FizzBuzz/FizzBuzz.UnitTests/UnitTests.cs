using System;
using FizzBuzz.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void InputSample1ProducesOutputSample1()
        {
            //Arrange
            var line = "3 5 10";
            var expected = "1 2 F 4 B F 7 8 F B";

            //Act
            string result = FizzBuzzer.GenerateSequence(line);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InputSample2ProducesOutputSample2()
        {
            //Arrange
            var line = "2 7 15";
            var expected = "1 F 3 F 5 F B F 9 F 11 F 13 FB 15";

            //Act
            string result = FizzBuzzer.GenerateSequence(line);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
