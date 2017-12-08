using Clinic.Core.Staffing;
using System.Collections.Generic;

namespace Clinic.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var medicalStaff = new MedicalStaff();

            string operation = args[0];

            if (operation == "add")
            {
                string doctorName = args[1];

                medicalStaff.Add(new Doctor { Name = doctorName });

                return;
            }
            
            if (operation == "list")
            {
                List<Doctor> doctors = medicalStaff.GetAll();

                doctors.ForEach(d => System.Console.WriteLine(d.Name));

                return;
            }

            System.Console.WriteLine("Unknown operation");
        }
    }
}
