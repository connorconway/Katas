using System;
using NUnit.Framework;

namespace StringCalculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(""));
            Assert.AreEqual(1, Calculator.Add("1"));
            Assert.AreEqual(3, Calculator.Add("1,2"));
            Assert.AreEqual(11, Calculator.Add("1,2,6,2"));
            Assert.AreEqual(3, Calculator.Add("1\n2"));
            Assert.AreEqual(11, Calculator.Add("1\n2,6\n2"));
            Assert.AreEqual(6, Calculator.Add("//;\n1;2;3"));
            Assert.Throws<ArgumentException>(() => Calculator.Add("-1, 2, -3"), "negatives not allowed: -1, -3");
            Assert.AreEqual(2, Calculator.Add("2,1001"));
            Assert.AreEqual(6, Calculator.Add("//[***]\n1***2***3"));
            Assert.AreEqual(6, Calculator.Add("//[*][%]\n1*2%3"));
        }
    }
}