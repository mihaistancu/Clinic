using System;
using System.Linq;

namespace Clinic.Core
{
    public class DoctorActivityReport
    {
        public int ClinicalVisitsCount { get; private set; }

        public double TotalAmountReceived { get; private set; }
        
        private DoctorActivityReport() { }

        public static DoctorActivityReport For(MedicalRecordsBook medicalRecordsBook, Doctor doctor, DateTime startDateTime, DateTime endDateTime)
        {
            var visits = medicalRecordsBook.Search(Filter.ByDoctor(doctor), Filter.ByTimeframe(startDateTime, endDateTime));

            return new DoctorActivityReport
            {
                ClinicalVisitsCount = visits.Count,
                TotalAmountReceived = visits.Sum(v => v.AmountReceived)
            };
        }
    }
}
