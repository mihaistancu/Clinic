using System.Collections.Generic;

namespace Clinic.Core.OfficeHours
{
    public class WeeklyOfficeHours
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Office Office { get; set; }
        public List<DailyOfficeHours> OfficeHours { get; set; }
    }
}
