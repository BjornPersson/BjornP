using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYear
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear()
        {
            Assert.IsTrue(LeapYear.IsLeapYear(1996));
        }
    }
}
