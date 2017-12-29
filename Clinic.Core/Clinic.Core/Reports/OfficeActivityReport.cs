using System;
using System.Linq;
using Clinic.Core.Consultations;
using Clinic.Core.Infrastructure;

namespace Clinic.Core.Reports
{
    public class OfficeActivityReport
    {
        public Office Office { get; private set; }
        public DateTime Date { get; private set; }
        public TimeSpan TotalVisitDuration { get; private set; }
        
        private OfficeActivityReport() { }

        public static OfficeActivityReport For(IRepository<ClinicalVisit> medicalRecordsBook, Office office, DateTime date)
        {
            var visits = medicalRecordsBook.Search(Filter.ByOffice(office), Filter.ByDate(date));

            return new OfficeActivityReport
            {
                Office = office,
                Date = date,
                TotalVisitDuration = new TimeSpan(visits.Sum(v => v.Duration.Ticks))
            };
        }
    }
}
