using System.Collections.Generic;

namespace Clinic.Core.Staffing
{
    public class MedicalStaff
    {
        private List<Doctor> doctors;

        public void Add(Doctor doctor)
        {
            doctors.Add(doctor);
        }
    }
}
