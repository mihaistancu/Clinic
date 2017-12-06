using System.Collections.Generic;

namespace Clinic.Core
{
    public class WeeklyOfficeHours
    {
        public Doctor Doctor { get; set; }

        public Office Office { get; set; }

        public List<DailyOfficeHours> OfficeHours { get; set; }
    }
}
