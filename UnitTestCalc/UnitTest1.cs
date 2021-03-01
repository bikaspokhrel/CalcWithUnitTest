using CalcWithUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCalc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            Form1 myform = new Form1();
            var Actual = myform.Add("4", "5");
            Assert.AreEqual(expected: "9", Actual);
        }
    }
}
