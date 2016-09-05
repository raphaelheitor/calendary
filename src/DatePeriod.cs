using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendary
{
    public class DatePeriod
    {
        private DateTime init;
        private DateTime end;
        private List<DateTime> exceptDates;
        private List<DateTime> periodDates;
        private List<DateTime> periodDatesBusinessDaysOnly;

        public List<DateTime> Period()
        {
            return periodDates;
        }
        public List<DateTime> PeriodWithBusinessDaysOnly()
        {
            if (periodDatesBusinessDaysOnly == null)
                periodDatesBusinessDaysOnly = periodDates
                    .Where(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday)
                    .ToList();
            return periodDatesBusinessDaysOnly;
        }

        public DatePeriod(DateTime init, DateTime end)
        {
            this.init = init.Date;
            this.end = end.Date;
            listOfDateInPeriod();
        }
        public DatePeriod(DateTime init, DateTime end, List<DateTime> exceptDates)
        {
            this.init = init.Date;
            this.end = end.Date;
            this.exceptDates = exceptDates;
            listOfDateInPeriod();
            removeExceptions();
        }
        private void removeExceptions()
        {
            this.periodDates = this.periodDates.Except<DateTime>(this.exceptDates, new DateComparer()).ToList();
        }
        private void listOfDateInPeriod()
        {
            this.periodDates = new List<DateTime>();
            var date = this.init;
            while (date <= this.end)
            {
                this.periodDates.Add(date);
                date = date.AddDays(1);
            }
        }
    }
}
