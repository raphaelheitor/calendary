using System;
using System.Collections.Generic;

namespace Calendary
{
    class DateComparer : IEqualityComparer<DateTime>
    {
        public bool Equals(DateTime x, DateTime y)
        {
            return x.Date == y.Date;
        }
        public int GetHashCode(DateTime x)
        {
            return x.Date.GetHashCode();
        }
    }
}
