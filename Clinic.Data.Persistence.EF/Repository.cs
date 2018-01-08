using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Clinic.Data.Persistence.EF
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

        public virtual List<T> Search(params Expression<Func<T, bool>>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                IQueryable<T> results = context.Set<T>();
            
                foreach (var predicate in predicates)
                {
                    results = results.Where(predicate);
                }

                return results.ToList();
            }
        }
    }
}
