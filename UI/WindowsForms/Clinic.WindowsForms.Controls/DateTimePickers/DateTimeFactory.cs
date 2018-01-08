using System;

namespace Clinic.WindowsForms.Controls.DateTimePickers
{
    public static class DateTimeFactory
    {
        public static DateTime Build(DateTime date, TimeSpan time)
        {
            return new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds);
        }
    }
}
