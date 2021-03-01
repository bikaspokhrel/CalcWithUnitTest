using CalcWithUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addition()
        {
            Form1 calform = new Form1();
            var Actual = calform.Add("10", "5");
            Assert.AreEqual(expected: "15", Actual);
        }
        [TestMethod]
        public void Mul()
        {
            Form1 calform = new Form1();
            var Actual = calform.Multiply("200", "50");
            Assert.AreEqual(expected: "10000", Actual);
        }
    }
}
