using System;
using System.Linq;
using Clinic.Data;
using Clinic.Data.Persistence;

namespace Clinic.Reports
{
    public class ClinicActivityReport
    {
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public TimeSpan TotalExaminationsDuration { get; private set; }
        public decimal TotalAmountReceived { get; private set; }

        private ClinicActivityReport() { }

        public static ClinicActivityReport For(IRepository<Examination> examinationsRepository, DateTime startDateTime, DateTime endDateTime)
        {
            var examinations = examinationsRepository.Search(Filter.ByTimeframe(startDateTime, endDateTime));

            return new ClinicActivityReport
            {
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                TotalExaminationsDuration = new TimeSpan(examinations.Sum(v => v.Duration.Ticks)),
                TotalAmountReceived = examinations.Sum(v => v.AmountReceived)
            };
        }
    }
}
