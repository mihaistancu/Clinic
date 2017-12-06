using System;

namespace Clinic.Core
{
    public class ClinicalVisit
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
