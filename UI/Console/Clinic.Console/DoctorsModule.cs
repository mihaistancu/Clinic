using Clinic.Data;
using Clinic.Data.Persistence.EF;

namespace Clinic.Console
{
    public class DoctorsModule : Module
    {
        readonly Repository<Doctor> repository;

        public DoctorsModule(Repository<Doctor> repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            repository.Add(new Doctor { Name = args[2] });
        }

        protected override void List()
        {
            foreach (var doctor in repository.GetAll())
            {
                System.Console.WriteLine(doctor.Name);
            }
        }
    }
}
