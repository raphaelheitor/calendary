using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace DatePeriodsException.test
{
    [TestFixture]
    public class DatePeriodTest
    {
        List<DateTime> listDt = new List<DateTime>();
        List<DateTime> listDt2 = new List<DateTime>();

        [OneTimeSetUp]
        public void Setup()
        {
            for (int i = 0; i <= 4; i++)
            {
                listDt.Add(DateTime.Now.AddDays(i));
            }
            for (int i = 0; i <= 7; i++)
            {
                listDt2.Add(DateTime.Now.AddDays(i));
            }
        }

        [Test]
        public void GivenPeriodeShouldReturnListofDateInInterval()
        {
            var d1 = DateTime.Now;
            var d2 = DateTime.Now.AddDays(4);

            DatePeriod dp = new DatePeriod(d1, d2);

            Assert.AreEqual(listDt[0].ToShortDateString(), dp.Period()[0].ToShortDateString());
            Assert.AreEqual(listDt[1].ToShortDateString(), dp.Period()[1].ToShortDateString());
            Assert.AreEqual(listDt[2].ToShortDateString(), dp.Period()[2].ToShortDateString());
            Assert.AreEqual(listDt[3].ToShortDateString(), dp.Period()[3].ToShortDateString());
            Assert.AreEqual(listDt[4].ToShortDateString(), dp.Period()[4].ToShortDateString());
            Assert.AreEqual(5, dp.Period().Count);
        }

        [Test]
        public void GivenPeriodeWithExceptDateListShouldReturnListofValidDatesInInterval()
        {
            var d1 = DateTime.Now;
            var d2 = DateTime.Now.AddDays(4);
            var except = new List<DateTime>();
            except.Add(DateTime.Now.AddDays(1));

            DatePeriod dp = new DatePeriod(d1, d2, except);

            Assert.AreEqual(listDt[0].ToShortDateString(), dp.Period()[0].ToShortDateString());
            Assert.AreEqual(listDt[2].ToShortDateString(), dp.Period()[1].ToShortDateString());
            Assert.AreEqual(listDt[3].ToShortDateString(), dp.Period()[2].ToShortDateString());
            Assert.AreEqual(listDt[4].ToShortDateString(), dp.Period()[3].ToShortDateString());
            Assert.AreEqual(4, dp.Period().Count);
        }
 
        [Test]
        public void GivenPeriodeWithExceptDateListShouldReturnListWithBusinessDayOnly()
        {
            var d1 = new DateTime(2016, 9, 5);
            var d2 = d1.AddDays(6);
            
            DatePeriod dp = new DatePeriod(d1, d2);

            Assert.AreEqual(listDt2[0].ToShortDateString(), dp.PeriodWithBusinessDaysOnly()[0].ToShortDateString());
            Assert.AreEqual(listDt2[1].ToShortDateString(), dp.PeriodWithBusinessDaysOnly()[1].ToShortDateString());
            Assert.AreEqual(listDt2[2].ToShortDateString(), dp.PeriodWithBusinessDaysOnly()[2].ToShortDateString());
            Assert.AreEqual(listDt2[3].ToShortDateString(), dp.PeriodWithBusinessDaysOnly()[3].ToShortDateString());
            Assert.AreEqual(listDt2[4].ToShortDateString(), dp.PeriodWithBusinessDaysOnly()[4].ToShortDateString());
            Assert.AreEqual(5, dp.PeriodWithBusinessDaysOnly().Count);
        }
    }
}