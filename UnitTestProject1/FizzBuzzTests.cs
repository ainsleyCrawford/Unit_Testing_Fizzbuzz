using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzNS
{
    [TestClass]
    public class FizzBuzzTests
    {
        FizzBuzz fb = new FizzBuzz();
        [TestMethod]
        public void TestFizz()
        {
            //Inputting multiples of 3
            Assert.AreEqual("Fizz", fb.FizzBuzzMethod(3));
            Assert.AreEqual("Fizz", fb.FizzBuzzMethod(-3));
            Assert.AreEqual("Fizz", fb.FizzBuzzMethod(-6));
            Assert.AreEqual("Fizz", fb.FizzBuzzMethod(42));
        }
        [TestMethod]
        public void TestBuzz()
        {
            //Inputting multiples of 5
            Assert.AreEqual("Buzz", fb.FizzBuzzMethod(5));
            Assert.AreEqual("Buzz", fb.FizzBuzzMethod(-10));
            Assert.AreEqual("Buzz", fb.FizzBuzzMethod(20));
            Assert.AreEqual("Buzz", fb.FizzBuzzMethod(605));
        }
        [TestMethod]
        public void TestFizzBuzz()
        {
            //Inputting common multiples of 3 and 5
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzMethod(15));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzMethod(-30));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzMethod(45));
            Assert.AreEqual("FizzBuzz", fb.FizzBuzzMethod(60));
        }
        [TestMethod]
        public void TestIntegers()
        {
            //Inputting numbers that are neither multiples of 3 nor 5
            Assert.AreEqual("1", fb.FizzBuzzMethod(1));
            Assert.AreEqual("-4", fb.FizzBuzzMethod(-4));
            Assert.AreEqual("7", fb.FizzBuzzMethod(7));
            Assert.AreEqual("11", fb.FizzBuzzMethod(11));
        }
    }
}
