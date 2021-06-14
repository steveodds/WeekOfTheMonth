using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WeekOfTheMonthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicDate()
        {
            var WeekMonth = new WeekOfTheMonth.WeekOfTheMonth();
            var week = WeekMonth.GetWeek("25/06/2021");
            Assert.AreEqual(week, 4);
        }

        [TestMethod]
        public void NoLeadingZeroInMonth()
        {
            var WeekMonth = new WeekOfTheMonth.WeekOfTheMonth();
            var week = WeekMonth.GetWeek("25/6/2021");
            Assert.AreEqual(week, 4);
        }

        [TestMethod]
        public void LeapYear()
        {
            var WeekMonth = new WeekOfTheMonth.WeekOfTheMonth();
            var week = WeekMonth.GetWeek("29/02/2020");
            Assert.AreEqual(week, 5);
        }

        [TestMethod]
        public void NonExistentDate()
        {
            var WeekMonth = new WeekOfTheMonth.WeekOfTheMonth();
            var week = WeekMonth.GetWeek("29/06/2021");
            Assert.AreEqual(week, 0);
        }
    }
}
