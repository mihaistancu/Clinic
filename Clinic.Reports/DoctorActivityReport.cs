using System;
using System.Linq;
using Clinic.Data;
using Clinic.Data.Persistence;

namespace Clinic.Reports
{
    public class DoctorActivityReport
    {
        public Doctor Doctor { get; private set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public int ExaminationsCount { get; private set; }
        public double TotalAmountReceived { get; private set; }
        
        private DoctorActivityReport() { }

        public static DoctorActivityReport For(IRepository<Examination> examinationsRepository, Doctor doctor, DateTime startDateTime, DateTime endDateTime)
        {
            var examinations = examinationsRepository.Search(Filter.ByDoctor(doctor), Filter.ByTimeframe(startDateTime, endDateTime));

            return new DoctorActivityReport
            {
                Doctor = doctor,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                ExaminationsCount = examinations.Count,
                TotalAmountReceived = examinations.Sum(v => v.AmountReceived)
            };
        }
    }
}
