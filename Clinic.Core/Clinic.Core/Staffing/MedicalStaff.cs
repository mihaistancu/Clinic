using System.Collections.Generic;

namespace Clinic.Core.Staffing
{
    public class MedicalStaff
    {
        private readonly List<Doctor> doctors;

        public MedicalStaff()
        {
            doctors = new List<Doctor>();
        }

        public void Add(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public List<Doctor> GetAll()
        {
            return doctors;
        }
    }
}
