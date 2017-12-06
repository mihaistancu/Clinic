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

        public List<ClinicalVisit> SearchBy(Office office)
        {
            return visits.Where(v => v.Office == office).ToList();
        }
    }
}
