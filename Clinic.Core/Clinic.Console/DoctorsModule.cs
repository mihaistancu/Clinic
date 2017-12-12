using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    class DoctorsModule
    {
        public void Execute(string[] args)
        {
            var medicalStaff = new Repository<Doctor>();

            if (args[1] == "add")
            {
                string doctorName = args[2];

                medicalStaff.Add(new Doctor { Name = doctorName });

                return;
            }

            if (args[1] == "list")
            {
                List<Doctor> doctors = medicalStaff.GetAll();

                doctors.ForEach(d => System.Console.WriteLine(d.Name));

                return;
            }
        }
    }
}
