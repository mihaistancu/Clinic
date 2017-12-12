using System.Collections.Generic;
using System.Linq;
using Clinic.Core.Infrastructure;

namespace Clinic.DataAccess
{
    public class OfficeRepository
    {
        public void Add(Office office)
        {
            using (var context = new ClinicDbContext())
            {
                context.Offices.Add(office);
                context.SaveChanges();
            }
        }

        public List<Office> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Offices.ToList();
            }
        }
    }
}
