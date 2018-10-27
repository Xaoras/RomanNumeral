using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeral;

namespace UnitTestRomanNum {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            int res = Roman.fromRoman("I");
            Assert.AreEqual(1, res);
        }
    }
}
