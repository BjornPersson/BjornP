using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void NineTeen96IsLeapYear()
        {
            Assert.IsTrue(LeapYear.IsLeapYear(1996));
        }

        [TestMethod]
        public void NineTeen99IsNotALeapYear()
        {
            Assert.IsFalse(LeapYear.IsLeapYear(1999));
        }

        [TestMethod]
        public void TwoThousandIsALeapYear()
        {
            Assert.IsTrue(LeapYear.IsLeapYear(2000));
        }

        [TestMethod]
        public void NineTeenHundredIsNotALeapYear()
        {
            Assert.IsFalse(LeapYear.IsLeapYear(1900));
        }
    }
}
