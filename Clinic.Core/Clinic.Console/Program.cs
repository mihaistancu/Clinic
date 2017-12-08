using Clinic.Core.Staffing;

namespace Clinic.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var medicalStaff = new MedicalStaff();

            string doctorName = args[0];

            medicalStaff.Add(new Doctor { Name = doctorName });
        }
    }
}
