using Clinic.Core;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Clinic.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T item)
        {
            using (var context = new ClinicDbContext())
            {
                context.Set<T>().Add(item);
                context.SaveChanges();
            }
        }

        public virtual List<T> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public virtual List<T> Search(params Func<T, bool>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                return context.Set<T>()
                    .Where(v => predicates.All(p => p(v)))
                    .ToList();
            }
        }
    }
}
