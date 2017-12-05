using System.Collections.Generic;

namespace Clinic.Core
{
    public class Schedule
    {
        public Doctor Doctor { get; set; }

        public Office Office { get; set; }

        public List<Availability> OfficeHours { get; set; }
    }
}
