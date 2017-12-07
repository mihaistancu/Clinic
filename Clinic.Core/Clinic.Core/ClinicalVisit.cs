using System;

namespace Clinic.Core
{
    public class ClinicalVisit
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Office Office { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double AmountReceived { get; set; }
        public TimeSpan Duration => EndDateTime - StartDateTime;
    }
}
