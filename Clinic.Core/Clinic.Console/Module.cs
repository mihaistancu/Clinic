using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    public abstract class Module<T> : IModule where T: class
    {
        protected abstract T Create(string[] args);

        protected abstract void Display(T item);

        public void Execute(string[] args)
        {
            var repository = new Repository<T>();

            if (args[1] == "add")
            {
                var newItem = Create(args);
                repository.Add(newItem);
                return;
            }

            if (args[1] == "list")
            {
                List<T> items = repository.GetAll();
                items.ForEach(Display);
                return;
            }
        }
    }
}
