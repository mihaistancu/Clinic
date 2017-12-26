using Clinic.Core.Staffing;

namespace Clinic.Console
{
    public class DoctorsModule : Module<Doctor>
    {
        protected override void Add(string[] args)
        {
            Repository.Add(new Doctor { Name = args[2] });
        }

        protected override void List()
        {
            foreach (var doctor in Repository.GetAll())
            {
                System.Console.WriteLine(doctor.Name);
            }
        }
    }
}
