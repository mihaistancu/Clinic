using System;
using System.Linq;
using Clinic.Core;

namespace Clinic.Reports
{
    public class OfficeActivityReport
    {
        public Office Office { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public TimeSpan TotalVisitDuration { get; private set; }
        
        private OfficeActivityReport() { }

        public static OfficeActivityReport For(IRepository<ClinicalVisit> medicalRecordsBook, Office office, DateTime startDateTime, DateTime endDateTime)
        {
            var visits = medicalRecordsBook.Search(Filter.ByOffice(office), Filter.ByTimeframe(startDateTime, endDateTime));

            return new OfficeActivityReport
            {
                Office = office,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                TotalVisitDuration = new TimeSpan(visits.Sum(v => v.Duration.Ticks))
            };
        }
    }
}
