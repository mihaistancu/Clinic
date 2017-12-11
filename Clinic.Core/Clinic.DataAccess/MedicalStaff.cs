using System.Collections.Generic;
using System.Linq;
using Clinic.Core.Staffing;

namespace Clinic.DataAccess
{
    public class MedicalStaff
    {
        public void Add(Doctor doctor)
        {
            using (var context = new ClinicDbContext())
            {
                context.Doctors.Add(doctor);
                context.SaveChanges();
            }   
        }

        public List<Doctor> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Doctors.ToList();
            } 
        }
    }
}
