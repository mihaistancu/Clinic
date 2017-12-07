using System;

namespace Clinic.Core.OfficeHours
{
    public class DailyOfficeHours
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
