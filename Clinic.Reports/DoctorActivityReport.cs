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
        public int ClinicalVisitsCount { get; private set; }
        public double TotalAmountReceived { get; private set; }
        
        private DoctorActivityReport() { }

        public static DoctorActivityReport For(IRepository<ClinicalVisit> medicalRecordsBook, Doctor doctor, DateTime startDateTime, DateTime endDateTime)
        {
            var visits = medicalRecordsBook.Search(Filter.ByDoctor(doctor), Filter.ByTimeframe(startDateTime, endDateTime));

            return new DoctorActivityReport
            {
                Doctor = doctor,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
                ClinicalVisitsCount = visits.Count,
                TotalAmountReceived = visits.Sum(v => v.AmountReceived)
            };
        }
    }
}
