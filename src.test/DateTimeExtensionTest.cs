using System;
using NUnit.Framework;
using ExtensionMethods;

namespace src.test
{
    [TestFixture]
    class DateTimeExtensionTest
    {
        [Test]
        public void GivenADateShouldReturnTomorrowDate()
        {
            var d1 = new DateTime(2016, 9, 5);
            Assert.AreEqual(new DateTime(2016, 9, 6).ToShortDateString(), d1.Tomorrow().ToShortDateString());
        }
        [Test]
        public void GivenADateShouldReturnYesterdayDate()
        {
            var d1 = new DateTime(2016, 9, 5);
            Assert.AreEqual(new DateTime(2016, 9, 4).ToShortDateString(), d1.Yesterday().ToShortDateString());
        }
        [Test]
        public void GivenADateShouldReturnTheAge()
        {
            var d1 = DateTime.Now.AddYears(-20).AddDays(5);
            Assert.AreEqual(19, d1.Age());
        }
        [Test]
        public void GivenATodayDayeShouldReturnTheAgeZero()
        {
            var d1 = DateTime.Now;
            Assert.AreEqual(0, d1.Age());
        }
        [Test]
        public void GivenADateShouldReturnTheAgeInDays()
        {
            var d1 = DateTime.Now.AddDays(-15);
            Assert.AreEqual(15, d1.AgeInDays());
        }

        [Test]
        public void GivenADateInRangeShouldReturnTrue()
        {
            var d1 = new DateTime(2016, 10, 20);
            var first = new DateTime(2016, 10, 20);
            var last = new DateTime(2016, 10, 25);
            Assert.AreEqual(true, d1.Between(first, last));
        }
        [Test]
        public void GivenADateOutOfRangeShouldReturnFalse()
        {
            var d1 = new DateTime(2016, 10, 19);
            var first = new DateTime(2016, 10, 20);
            var last = new DateTime(2016, 10, 25);
            Assert.AreEqual(false, d1.Between(first, last));
        }

        [Test]
        public void GivenADateShouldReturnTrueIfIsBirthdayDate()
        {
            var d1 = new DateTime(2000, 10, 21);
            var birthday = new DateTime(2016, 10, 21);
            Assert.AreEqual(true, d1.IsBirthday(birthday));
        }
        [Test]
        public void GivenADateShouldReturnFalseIfNoBirthdayDate()
        {
            var d1 = new DateTime(2000, 10, 21);
            var noBirthday = new DateTime(2016, 10, 11);
            Assert.AreEqual(false, d1.IsBirthday(noBirthday));
        }

        [Test]
        public void GivenAFutureDateShouldReturnTrue()
        {
            var d1 = new DateTime(2016, 10, 21);
            Assert.AreEqual(true, d1.IsFuture());
        }

        [Test]
        public void GivenAPastDateShouldReturnTrue()
        {
            var d1 = new DateTime(2016, 10, 19);
            Assert.AreEqual(true, d1.IsPast());
        }
        [Test]
        public void GivenAFutureDateShouldReturnFalse()
        {
            var d1 = new DateTime(2016, 10, 21);
            Assert.AreEqual(false, d1.IsPast());
        }

        [Test]
        public void GivenAPastDateShouldReturnFalse()
        {
            var d1 = new DateTime(2016, 10, 19);
            Assert.AreEqual(false, d1.IsFuture());
        }

        [Test]
        public void GivenADateWhenCheckDayofWeekShouldReturnExpectedDay()
        {
            var d1 = new DateTime(2016, 10, 21);
            Assert.AreEqual(true, d1.IsFriday());
        }
        [Test]
        public void GivenADateWhenCheckDayofWeekShouldReturnUnexpectedDay()
        {
            var d1 = new DateTime(2016, 10, 20);
            Assert.AreEqual(false, d1.IsFriday());
        }

        [Test]
        public void GivenADateShoulRetornTheNextSunday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextSunday = new DateTime(2016, 10, 23);
            Assert.AreEqual(nextSunday.Date, d1.NextSunday().Date);
        }
        [Test]
        public void GivenASundayShoulRetornTheNextSunday()
        {
            var d1 = new DateTime(2016, 10, 16);

            var nextSunday = new DateTime(2016, 10, 23);
            Assert.AreEqual(nextSunday.Date, d1.NextSunday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextMonday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextMonday = new DateTime(2016, 10, 24);
            Assert.AreEqual(nextMonday.Date, d1.NextMonday().Date);
        }
        [Test]
        public void GivenAMondayShoulRetornTheNextMonday()
        {
            var d1 = new DateTime(2016, 10, 17);

            var nextMonday = new DateTime(2016, 10, 24);
            Assert.AreEqual(nextMonday.Date, d1.NextMonday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextTuesday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextTuesday = new DateTime(2016, 10, 25);
            Assert.AreEqual(nextTuesday.Date, d1.NextTuesday().Date);
        }
        [Test]
        public void GivenATuesdayShoulRetornTheNextTuesday()
        {
            var d1 = new DateTime(2016, 10, 18);

            var nextTuesday = new DateTime(2016, 10, 25);
            Assert.AreEqual(nextTuesday.Date, d1.NextTuesday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextWednesday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextWednesday = new DateTime(2016, 10, 26);
            Assert.AreEqual(nextWednesday.Date, d1.NextWednesday().Date);
        }
        [Test]
        public void GivenAWednesdayShoulRetornTheNextWednesday()
        {
            var d1 = new DateTime(2016, 10, 19);

            var nextWednesday = new DateTime(2016, 10, 26);
            Assert.AreEqual(nextWednesday.Date, d1.NextWednesday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextThursday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextThursday = new DateTime(2016, 10, 27);
            Assert.AreEqual(nextThursday.Date, d1.NextThursday().Date);
        }
        [Test]
        public void GivenAThursdayShoulRetornTheNextThursday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextThursday = new DateTime(2016, 10, 27);
            Assert.AreEqual(nextThursday.Date, d1.NextThursday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextFriday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextFriday = new DateTime(2016, 10, 21);
            Assert.AreEqual(nextFriday.Date, d1.NextFriday().Date);
        }
        [Test]
        public void GivenAFridayShoulRetornTheNextFriday()
        {
            var d1 = new DateTime(2016, 10, 21);

            var nextFriday = new DateTime(2016, 10, 28);
            Assert.AreEqual(nextFriday.Date, d1.NextFriday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheNextSaturday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var nextSaturday = new DateTime(2016, 10, 22);
            Assert.AreEqual(nextSaturday.Date, d1.NextSaturday().Date);
        }
        [Test]
        public void GivenASaturdayShoulRetornTheNextSaturday()
        {
            var d1 = new DateTime(2016, 10, 22);

            var nextSaturday = new DateTime(2016, 10, 29);
            Assert.AreEqual(nextSaturday.Date, d1.NextSaturday().Date);
        }

        [Test]
        public void GivenADateShoulRetornTheLastSunday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastSunday = new DateTime(2016, 10, 16);
            Assert.AreEqual(lastSunday.Date, d1.LastSunday().Date);
        }
        [Test]
        public void GivenASundayShoulRetornTheLastSunday()
        {
            var d1 = new DateTime(2016, 10, 23);

            var nextSunday = new DateTime(2016, 10, 16);
            Assert.AreEqual(nextSunday.Date, d1.LastSunday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastMonday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastMonday = new DateTime(2016, 10, 17);
            Assert.AreEqual(lastMonday.Date, d1.LastMonday().Date);
        }
        [Test]
        public void GivenAMondayShoulRetornTheLastMonday()
        {
            var d1 = new DateTime(2016, 10, 24);

            var lastMonday = new DateTime(2016, 10, 17);
            Assert.AreEqual(lastMonday.Date, d1.LastMonday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastTuesday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastTuesday = new DateTime(2016, 10, 18);
            Assert.AreEqual(lastTuesday.Date, d1.LastTuesday().Date);
        }
        [Test]
        public void GivenATuesdayShoulRetornTheLastTuesday()
        {
            var d1 = new DateTime(2016, 10, 25);

            var lastTuesday = new DateTime(2016, 10, 18);
            Assert.AreEqual(lastTuesday.Date, d1.LastTuesday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastWednesday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastWednesday = new DateTime(2016, 10, 19);
            Assert.AreEqual(lastWednesday.Date, d1.LastWednesday().Date);
        }
        [Test]
        public void GivenAWednesdayShoulRetornTheLastWednesday()
        {
            var d1 = new DateTime(2016, 10, 26);

            var lastWednesday = new DateTime(2016, 10, 19);
            Assert.AreEqual(lastWednesday.Date, d1.LastWednesday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastThursday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastThursday = new DateTime(2016, 10, 13);
            Assert.AreEqual(lastThursday.Date, d1.LastThursday().Date);
        }
        [Test]
        public void GivenAThursdayShoulRetornTheLastThursday()
        {
            var d1 = new DateTime(2016, 10, 27);

            var lastThursday = new DateTime(2016, 10, 20);
            Assert.AreEqual(lastThursday.Date, d1.LastThursday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastFriday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastFriday = new DateTime(2016, 10, 14);
            Assert.AreEqual(lastFriday.Date, d1.LastFriday().Date);
        }
        [Test]
        public void GivenAFridayShoulRetornTheLastFriday()
        {
            var d1 = new DateTime(2016, 10, 28);

            var lastFriday = new DateTime(2016, 10, 21);
            Assert.AreEqual(lastFriday.Date, d1.LastFriday().Date);
        }
        [Test]
        public void GivenADateShoulRetornTheLastSaturday()
        {
            var d1 = new DateTime(2016, 10, 20);

            var lastSaturday = new DateTime(2016, 10, 15);
            Assert.AreEqual(lastSaturday.Date, d1.LastSaturday().Date);
        }
        [Test]
        public void GivenASaturdayShoulRetornTheLastSaturday()
        {
            var d1 = new DateTime(2016, 10, 29);

            var lastSaturday = new DateTime(2016, 10, 22);
            Assert.AreEqual(lastSaturday.Date, d1.LastSaturday().Date);
        }
    }
}
