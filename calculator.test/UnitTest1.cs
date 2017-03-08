using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using NUnit.Framework;

namespace calculator.test
{
    [TestFixture]
    public class UnitTest1
    {
        private Calculator calculator;
        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }
        [Test]
        public void Divide_Should_Return_CorrectResult()
        {
            var int1 = 21;
            var int2 = 3;
            var expected = 7;
            var result = calculator.Divide(int1, int2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_Should_Throw_DivideByZeroException()
        {
            var zero = 0;
            var number = 10;
            Assert.Throws<DivideByZeroException>(
                ()=> calculator.Divide(number, zero));
        }

        [Test]
        public void Add_Should_GetCorrectResult()
        {
            var n1 = 2;
            var n2 = 5;
            var expected = 7;
            var actual = calculator.Add(n1, n2);

            Assert.AreEqual(expected, actual);
        }

    }
}
