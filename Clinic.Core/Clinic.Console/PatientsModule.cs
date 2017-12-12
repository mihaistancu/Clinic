using Clinic.Core.Patients;
using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    public class PatientsModule
    {
        public void Execute(string[] args)
        {
            var patientRepository = new Repository<Patient>();

            if (args[1] == "add")
            {
                string patientName = args[2];

                patientRepository.Add(new Patient { Name = patientName });

                return;
            }

            if (args[1] == "list")
            {
                List<Patient> patients = patientRepository.GetAll();

                patients.ForEach(d => System.Console.WriteLine(d.Name));

                return;
            }
        }
    }
}
