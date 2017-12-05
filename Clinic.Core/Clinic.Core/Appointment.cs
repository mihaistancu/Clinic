using System;

namespace Clinic.Core
{
    public class Appointment
    {
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
