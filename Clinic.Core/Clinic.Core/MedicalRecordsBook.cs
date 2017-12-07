using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Core
{
    public class MedicalRecordsBook
    {
        private readonly List<ClinicalVisit> visits;

        public MedicalRecordsBook()
        {
            visits = new List<ClinicalVisit>();
        }

        public void Add(ClinicalVisit visit)
        {
            visits.Add(visit);    
        }

        public List<ClinicalVisit> SearchBy(Office office, DateTime startDateTime, DateTime endDateTime)
        {
            return visits.Where(v =>
                    v.Office == office &&
                    v.StartDateTime >= startDateTime &&
                    v.EndDateTime <= endDateTime)
                .ToList();
        }

        public List<ClinicalVisit> SearchBy(Doctor doctor, DateTime startDateTime, DateTime endDateTime)
        {
            return visits.Where(v =>
                    v.Doctor == doctor &&
                    v.StartDateTime >= startDateTime &&
                    v.EndDateTime <= endDateTime)
                .ToList();
        }
    }
}
