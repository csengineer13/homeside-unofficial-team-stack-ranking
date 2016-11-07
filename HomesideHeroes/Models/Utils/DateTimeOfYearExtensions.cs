using System;

namespace HomesideHeroes.Models.Utils
{
    public static class DateTimeOfYearExtensions
    {
        public static DateTime FirstDayOfYear(this DateTime value)
        {
            return new DateTime(value.Year, 1, 1);
        }

        public static DateTime LastDayOfYear(this DateTime value)
        {
            var temp = new DateTime(value.Year, 12, 1);
            return new DateTime(value.Year, 12, temp.DaysInMonth());
        }
    }
}