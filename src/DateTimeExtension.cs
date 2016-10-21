using System;

namespace ExtensionMethods
{
    public static class CalendaryExtensionMethods
    {
        public static DateTime Tomorrow(this DateTime date)
        {
            return date.AddDays(1);
        }
        public static DateTime Yesterday(this DateTime date)
        {
            return date.AddDays(-1);
        }
        public static int Age(this DateTime date)
        {
            var now = DateTime.Now;
            var age = now.Year - date.Year;
            if (now.Month > date.Month || (now.Month == date.Month && now.Day < date.Day))
                age -= 1;
            return age;
                
        }
        public static int AgeInDays(this DateTime date)
        {
            TimeSpan ts = DateTime.Now - date;
            return ts.Duration().Days;
        }
        public static int RemainingDaysInYear(this DateTime date)
        {
            TimeSpan ts = new DateTime(date.Year, 12, 31) - date;
            return ts.Duration().Days;
        }
        public static int RemainingDaysInMonth(this DateTime date)
        {
            TimeSpan ts = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1) - date;
            return ts.Duration().Days;
        }

        public static bool Between(this DateTime date, DateTime first, DateTime last)
        {
            return (date.Date >= first.Date && date.Date <= last.Date) ? true : false;
        }

        public static bool IsBirthday(this DateTime date, DateTime dateToCheck)
        {
            if (dateToCheck.Year <= date.Year)
            {
                return false;
            }
            return dateToCheck.Month == date.Month && dateToCheck.Day == date.Day;
        }
        public static bool IsBirthday(this DateTime date)
        {
            if (DateTime.Now.Year <= date.Year)
            {
                return false;
            }
            return DateTime.Now.Month == date.Month && DateTime.Now.Day == date.Day;
        }

        public static bool IsFuture(this DateTime date)
        {
            return (date.Date > DateTime.Now) ? true : false;
        }
        public static bool IsPast(this DateTime date)
        {
            return (date.Date < DateTime.Now) ? true : false;
        }

        public static bool IsSunday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Sunday)) ? true : false;
        }
        public static bool IsMonday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Monday)) ? true : false;
        }
        public static bool IsTuesday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Tuesday)) ? true : false;
        }
        public static bool IsWednesday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Wednesday)) ? true : false;
        }
        public static bool IsThursday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Thursday)) ? true : false;
        }
        public static bool IsFriday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Friday)) ? true : false;
        }
        public static bool IsSaturday(this DateTime date)
        {
            return (date.DayOfWeek.Equals(DayOfWeek.Saturday)) ? true : false;
        }
        public static DateTime NextSunday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Sunday);
        }
        public static DateTime NextMonday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Monday);
        }
        public static DateTime NextTuesday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Tuesday);
        }
        public static DateTime NextWednesday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Wednesday);
        }
        public static DateTime NextThursday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Thursday);
        }
        public static DateTime NextFriday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Friday);
        }
        public static DateTime NextSaturday(this DateTime date)
        {
            return CheckNextDayOfWeek(date, DayOfWeek.Saturday);
        }

        private static DateTime CheckNextDayOfWeek(DateTime date, DayOfWeek returnDay)
        {
            int i = 0;
            while (!date.DayOfWeek.Equals(returnDay))
            {
                date = date.AddDays(1);
                i++;
            }

            return (i == 0) ? date.AddDays(7) : date;
        }

        public static DateTime LastSunday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Sunday);
        }
        public static DateTime LastMonday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Monday);
        }
        public static DateTime LastTuesday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Tuesday);
        }
        public static DateTime LastWednesday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Wednesday);
        }
        public static DateTime LastThursday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Thursday);
        }
        public static DateTime LastFriday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Friday);
        }
        public static DateTime LastSaturday(this DateTime date)
        {
            return CheckLastDayOfWeek(date, DayOfWeek.Saturday);
        }

        private static DateTime CheckLastDayOfWeek(DateTime date, DayOfWeek returnDay)
        {
            int i = 0;
            while (!date.DayOfWeek.Equals(returnDay))
            {
                date = date.AddDays(-1);
                i++;
            }

            return (i == 0) ? date.AddDays(-7) : date;
        }
    }
}
