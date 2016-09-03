using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace src.test
{
    [TestClass]
    public class DatePeriodTest
    {
        List<DateTime> listDt = new List<DateTime>();

        [TestInitialize]
        public void Setup()
        {
            for (int i = 0; i <= 4; i++)
            {
                listDt.Add(DateTime.Now.AddDays(i));
            }
        }

        [TestMethod]
        public void GivenPeriodeShouldReturnListofDateInInterval()
        {
            var d1 = DateTime.Now;
            var d2 = DateTime.Now.AddDays(4);

            DatePeriod dp = new DatePeriod(d1, d2);

            Assert.AreEqual(listDt[0].ToShortDateString(), dp.PeriodDates[0].ToShortDateString());
            Assert.AreEqual(listDt[1].ToShortDateString(), dp.PeriodDates[1].ToShortDateString());
            Assert.AreEqual(listDt[2].ToShortDateString(), dp.PeriodDates[2].ToShortDateString());
            Assert.AreEqual(listDt[3].ToShortDateString(), dp.PeriodDates[3].ToShortDateString());
            Assert.AreEqual(listDt[4].ToShortDateString(), dp.PeriodDates[4].ToShortDateString());
            Assert.AreEqual(5, dp.PeriodDates.Count);
        }

        [TestMethod]
        public void GivenPeriodeWithExceptDateListShouldReturnListofValidDatesInInterval()
        {
            var d1 = DateTime.Now;
            var d2 = DateTime.Now.AddDays(4);
            var except = new List<DateTime>();
            except.Add(DateTime.Now.AddDays(1));

            DatePeriod dp = new DatePeriod(d1, d2, except);

            Assert.AreEqual(listDt[0].ToShortDateString(), dp.PeriodDates[0].ToShortDateString());
            Assert.AreEqual(listDt[2].ToShortDateString(), dp.PeriodDates[1].ToShortDateString());
            Assert.AreEqual(listDt[3].ToShortDateString(), dp.PeriodDates[2].ToShortDateString());
            Assert.AreEqual(listDt[4].ToShortDateString(), dp.PeriodDates[3].ToShortDateString());
            Assert.AreEqual(4, dp.PeriodDates.Count);
        }

    }
}