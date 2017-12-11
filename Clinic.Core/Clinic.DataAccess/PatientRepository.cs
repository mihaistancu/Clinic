using System.Collections.Generic;
using Clinic.Core.Patients;

namespace Clinic.DataAccess
{
    public class PatientRepository
    {
        private List<Patient> patients;

        public void Add(Patient patient)
        {
            patients.Add(patient);
        }
    }
}
