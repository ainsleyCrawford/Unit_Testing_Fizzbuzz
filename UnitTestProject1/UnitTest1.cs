using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FizzBuzzClass fb = new FizzBuzzClass();
            Assert.AreEqual("Fizz", fb.FizzBuzzProgram(42));
        }
    }
}
