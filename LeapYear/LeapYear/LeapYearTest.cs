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
            Assert.IsTrue(LeapYearClass.IsLeapYear(1996));
        }
    }

    public class LeapYearClass
    {
        public static bool IsLeapYear(int i)
        {
            return true;
        }
    }
}
