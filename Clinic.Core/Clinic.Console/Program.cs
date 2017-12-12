using Clinic.Core.Staffing;
using System.Collections.Generic;
using Clinic.Core.Infrastructure;
using Clinic.Core.Patients;
using Clinic.DataAccess;

namespace Clinic.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var medicalStaff = new MedicalStaff();
            var patientRepository = new PatientRepository();
            var officeRepository = new OfficeRepository();

            string module = args[0];
            string operation = args[1];

            if (module == "doctors")
            {
                if (operation == "add")
                {
                    string doctorName = args[2];

                    medicalStaff.Add(new Doctor { Name = doctorName });

                    return;
                }

                if (operation == "list")
                {
                    List<Doctor> doctors = medicalStaff.GetAll();

                    doctors.ForEach(d => System.Console.WriteLine(d.Name));

                    return;
                }
            }

            if (module == "patients")
            {
                if (operation == "add")
                {
                    string patientName = args[2];

                    patientRepository.Add(new Patient { Name = patientName });

                    return;
                }

                if (operation == "list")
                {
                    List<Patient> patients = patientRepository.GetAll();

                    patients.ForEach(d => System.Console.WriteLine(d.Name));

                    return;
                }
            }

            if (module == "offices")
            {
                if (operation == "add")
                {
                    string officeLocation = args[2];

                    officeRepository.Add(new Office { Location = officeLocation });

                    return;
                }

                if (operation == "list")
                {
                    List<Office> offices = officeRepository.GetAll();

                    offices.ForEach(d => System.Console.WriteLine(d.Location));

                    return;
                }
            }

            System.Console.WriteLine("Unknown operation");
        }
    }
}
