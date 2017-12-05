using System;

namespace Clinic.Core
{
    public class PacientVisit
    {
        public Pacient Pacient { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
