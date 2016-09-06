using System;

namespace ExtensionMethods
{
    public static class MyExtensionMethods
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
            if (now.Month > date.Month || (now.Month == date.Month && now.Day < date.Month))
                age -= 1;
            return age;
                
        }
        public static int AgeInDays(this DateTime date)
        {
            TimeSpan ts = DateTime.Now - date;
            return ts.Duration().Days;
        }
    }
}
