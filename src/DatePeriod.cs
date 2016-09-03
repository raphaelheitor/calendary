using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class DatePeriod
    {
        private DateTime init;
        private DateTime end;
        private List<DateTime> exceptDates;
        private List<DateTime> periodDates;

        public List<DateTime> PeriodDates
        {
            get
            {
                return periodDates;
            }
        }

        public DatePeriod(DateTime init, DateTime end)
        {
            this.init = init.Date;
            this.end = end.Date;
            this.exceptDates = new List<DateTime>();
            listOfDateInPeriod();
        }
        public DatePeriod(DateTime init, DateTime end, List<DateTime> exceptDates)
        {
            this.init = init.Date;
            this.end = end.Date;
            this.exceptDates = exceptDates;
            listOfDateInPeriod();
        }


        private void listOfDateInPeriod()
        {
            this.periodDates = new List<DateTime>();
            var date = this.init;
            while (date <= this.end)
            {
                if (!this.exceptDates.Contains<DateTime>(date.Date, new DateComparer()))
                    this.periodDates.Add(date);
                date = date.AddDays(1);
            }
        }
    }
}
