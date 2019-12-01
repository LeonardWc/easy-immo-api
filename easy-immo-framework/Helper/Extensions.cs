using System;
using System.Globalization;

namespace easy_immo_framework.Helper
{
    public static class Extensions
    {
        public static DateTime ToDate(this string date, string defaultFormat = "yyyy-MM-dd")
        {
            if (DateTime.TryParseExact(date, defaultFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                return result;
            return DateTime.MinValue;
        }

        public static double ToDouble(this string number)
        {
            if (double.TryParse(number, NumberStyles.Float, CultureInfo.InvariantCulture, out double resultDot))
                return resultDot;
            if (double.TryParse(number, out double resultComma))
                return resultComma;
            return 0;
        }

        public static int ToInteger(this string number)
        {
            if (Int32.TryParse(number, out int result))
                return result;
            return 0;
        }
    }
}