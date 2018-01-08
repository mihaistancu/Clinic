using System;

namespace Clinic.Data
{
    public class OfficeHours
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Office Office { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
