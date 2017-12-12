using Clinic.Core.Staffing;

namespace Clinic.Console
{
    public class DoctorsModule : Module<Doctor>
    {
        protected override Doctor Create(string[] args)
        {
            return new Doctor { Name = args[2] };
        }

        protected override void Display(Doctor item)
        {
            System.Console.WriteLine(item.Name);
        }
    }
}
