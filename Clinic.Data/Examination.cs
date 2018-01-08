using System;

namespace Clinic.Data
{
    public class Examination
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Office Office { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double AmountReceived { get; set; }
        public TimeSpan Duration => EndDateTime - StartDateTime;
    }
}
