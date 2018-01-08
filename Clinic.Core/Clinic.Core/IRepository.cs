using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Clinic.Data
{
    public interface IRepository<T>
    {
        void Add(T item);

        List<T> GetAll();

        List<T> Search(params Expression<Func<T, bool>>[] predicates);
    }
}
