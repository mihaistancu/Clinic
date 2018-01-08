using Clinic.Core;
using Clinic.DataAccess;

namespace Clinic.Console
{
    public class OfficesModule : Module
    {
        Repository<Office> repository;

        public OfficesModule(Repository<Office> repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            repository.Add(new Office { Location = args[2] });
        }

        protected override void List()
        {
            foreach(var office in repository.GetAll())
            {
                System.Console.WriteLine(office.Location);
            }
        }
    }
}
