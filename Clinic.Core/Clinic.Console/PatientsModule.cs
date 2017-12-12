using Clinic.Core.Patients;

namespace Clinic.Console
{
    public class PatientsModule : Module<Patient>
    {
        protected override Patient Create(string[] args)
        {
            return new Patient { Name = args[2] };
        }

        protected override void Display(Patient item)
        {
            System.Console.WriteLine(item.Name);
        }
    }
}
