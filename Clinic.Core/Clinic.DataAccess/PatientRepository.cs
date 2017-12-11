using System.Collections.Generic;
using System.Linq;
using Clinic.Core.Patients;

namespace Clinic.DataAccess
{
    public class PatientRepository
    {
        public void Add(Patient patient)
        {
            using (var context = new ClinicDbContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }

        public List<Patient> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Patients.ToList();
            }
        }
    }
}
