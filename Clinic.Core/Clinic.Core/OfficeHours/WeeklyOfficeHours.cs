using System.Collections.Generic;
using Clinic.Core.Staffing;

namespace Clinic.Core.OfficeHours
{
    public class WeeklyOfficeHours
    {
        public Doctor Doctor { get; set; }

        public Office Office { get; set; }

        public List<DailyOfficeHours> OfficeHours { get; set; }
    }
}
