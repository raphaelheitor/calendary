using System;
using NUnit.Framework;
using System.Linq;
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
            Assert.AreEqual(d1.Tomorrow().ToShortDateString(), new DateTime(2016, 9, 4).ToShortDateString());
        }
        [Test]
        public void GivenADateShouldReturnYesterdayDate()
        {
            var d1 = new DateTime(2016, 9, 5);
            Assert.AreEqual(d1.Yesterday().ToShortDateString(), new DateTime(2016, 9, 6).ToShortDateString());
        }
        [Test]
        public void GivenADateShouldReturnTheAge()
        {
            var d1 = DateTime.Now.AddYears(-20).AddDays(5);
            Assert.AreEqual(19, d1.Age());
        }
        [Test]
        public void GivenADateShouldReturnTheAgeInDays()
        {
            var d1 = DateTime.Now.AddDays(-15);
            Assert.AreEqual(15, d1.AgeInDays());
        }
    }
}
