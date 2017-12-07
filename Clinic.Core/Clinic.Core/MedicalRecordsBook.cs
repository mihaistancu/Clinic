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
        
        public List<ClinicalVisit> Search(params Func<ClinicalVisit, bool>[] predicates)
        {
            return visits.Where(v => predicates.All(p => p(v))).ToList();
        }
    }
}
