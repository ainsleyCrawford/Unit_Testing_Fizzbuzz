using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class UnitTests
    {
        FizzBuzzClass fb = new FizzBuzzClass();
        [TestMethod]
        public void TestFizz()
        {
            //Inputting a multiple of 3
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(42));
        }
        [TestMethod]
        public void TestBuzz()
        {
            //Inputting a multiple of 5
            Assert.AreEqual("Buzz", fb.FizzBuzzProgram(20));
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            //Inputting a common multiple of 3 and 5
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzProgram(60));
        }
        [TestMethod]
        public void TestIntegers()
        {
            //Inputting a number that is neither a multiple of 3 nor 5
            Assert.AreEqual("11", fb.FizzBuzzProgram(11));
        }
    }
}
