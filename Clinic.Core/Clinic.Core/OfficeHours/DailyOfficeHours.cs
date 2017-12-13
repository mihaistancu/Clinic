using System;

namespace Clinic.Core.OfficeHours
{
    public class DailyOfficeHours
    {
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
