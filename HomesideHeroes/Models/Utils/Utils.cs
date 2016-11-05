using System;

namespace HomesideHeroes.Models.Utils
{
    public static class Utils
    {
        public static string ToPluralsightDateTime(this DateTime dateTime)
        {
            return dateTime.ToString("YYYY-MM-DD");
        }
    }
}