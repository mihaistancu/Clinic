using System.Collections.Generic;
using System.Linq;

namespace Clinic.DataAccess
{
    public class Repository<T> where T : class
    {
        public void Add(T doctor)
        {
            using (var context = new ClinicDbContext())
            {
                context.Set<T>().Add(doctor);
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Set<T>().ToList();
            }
        }
    }
}
