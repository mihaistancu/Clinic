using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    public abstract class Module<T> : IModule where T: class
    {
        protected Repository<T> Repository { get; set; }

        public Module()
        {
            Repository = new Repository<T>();
        }

        protected abstract void Add(string[] args);

        protected abstract void List();

        public void Execute(string[] args)
        {
            switch (args[1])
            {
                case "add": Add(args); break;
                case "list": List(); break;
            }
        }
    }
}
