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
            //Inputting multiples of 3
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(3));
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(-3));
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(-6));
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(42));
        }
        [TestMethod]
        public void TestBuzz()
        {
            //Inputting multiples of 5
            Assert.AreEqual("Buzz", fb.FizzBuzzProgram(5));
            Assert.AreEqual("Buzz", fb.FizzBuzzProgram(-10));
            Assert.AreEqual("Buzz", fb.FizzBuzzProgram(20));
            Assert.AreEqual("Buzz", fb.FizzBuzzProgram(605));
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            //Inputting common multiples of 3 and 5
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzProgram(15));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzProgram(-30));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzProgram(45));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzProgram(60));
        }
        [TestMethod]
        public void TestIntegers()
        {
            //Inputting numbers that are neither multiples of 3 nor 5
            Assert.AreEqual("1", fb.FizzBuzzProgram(1));
            Assert.AreEqual("-4", fb.FizzBuzzProgram(-4));
            Assert.AreEqual("7", fb.FizzBuzzProgram(7));
            Assert.AreEqual("11", fb.FizzBuzzProgram(11));
        }
    }
}
