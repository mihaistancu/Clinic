using System;
using System.Linq;
using Clinic.Core.Consultations;

namespace Clinic.Core.Reports
{
    public class ClinicActivityReport
    {
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public TimeSpan TotalVisitsDuration { get; private set; }
        public double TotalAmountReceived { get; private set; }

        private ClinicActivityReport() { }

        public static ClinicActivityReport For(MedicalRecordsBook medicalRecordsBook, DateTime startDateTime, DateTime endDateTime)
        {
            var visits = medicalRecordsBook.Search(Filter.ByTimeframe(startDateTime, endDateTime));

            return new ClinicActivityReport
            {
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                TotalVisitsDuration = new TimeSpan(visits.Sum(v => v.Duration.Ticks)),
                TotalAmountReceived = visits.Sum(v => v.AmountReceived)
            };
        }
    }
}
