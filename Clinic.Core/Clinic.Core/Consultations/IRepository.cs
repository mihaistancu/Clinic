using System;
using System.Collections.Generic;

namespace Clinic.Core
{
    public interface IRepository<T>
    {
        void Add(T item);

        List<T> GetAll();

        List<T> Search(params Func<T, bool>[] predicates);
    }
}
