using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtractDay
{
    internal class UserProgramCode
    {

        public static string FindDay(string date)
    {
        DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime newDate = dt.AddYears(1);
        return newDate.DayOfWeek.ToString();
    }

}
}
