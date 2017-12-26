using Clinic.Core.Patients;

namespace Clinic.Console
{
    public class PatientsModule : Module<Patient>
    {
        protected override void Add(string[] args)
        {
            Repository.Add(new Patient { Name = args[2] });
        }

        protected override void List()
        {
            foreach(var patient in Repository.GetAll())
            {
                System.Console.WriteLine(patient.Name);
            }
        }
    }
}
