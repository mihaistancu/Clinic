using System.Collections.Generic;

namespace Clinic.Core.Patients
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
