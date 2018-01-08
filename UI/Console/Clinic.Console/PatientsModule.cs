using Clinic.Data;
using Clinic.Data.Persistence;

namespace Clinic.Console
{
    public class PatientsModule : Module
    {
        readonly Repository<Patient> repository;

        public PatientsModule(Repository<Patient> repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            repository.Add(new Patient { Name = args[2] });
        }

        protected override void List()
        {
            foreach(var patient in repository.GetAll())
            {
                System.Console.WriteLine(patient.Name);
            }
        }
    }
}
