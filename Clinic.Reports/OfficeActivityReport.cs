using System;
using System.Linq;
using Clinic.Data;
using Clinic.Data.Persistence;

namespace Clinic.Reports
{
    public class OfficeActivityReport
    {
        public Office Office { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public TimeSpan TotalExaminationsDuration { get; private set; }
        
        private OfficeActivityReport() { }

        public static OfficeActivityReport For(IRepository<Examination> examinationsRepository, Office office, DateTime startDateTime, DateTime endDateTime)
        {
            var examinations = examinationsRepository.Search(Filter.ByOffice(office), Filter.ByTimeframe(startDateTime, endDateTime));

            return new OfficeActivityReport
            {
                Office = office,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                TotalExaminationsDuration = new TimeSpan(examinations.Sum(v => v.Duration.Ticks))
            };
        }
    }
}
