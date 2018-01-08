using System;

namespace Clinic.Data
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
    }
}
