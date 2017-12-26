using Clinic.Core.Infrastructure;
using Clinic.Core.OfficeHours;
using Clinic.Core.Patients;
using Clinic.Core.Staffing;
using Clinic.DataAccess;
using System.Collections.Generic;

namespace Clinic.Console
{
    class Program
    {
        static Dictionary<string, Module> moduleMap = new Dictionary<string, Module>
        {
            { "doctors", new DoctorsModule(new Repository<Doctor>()) },
            { "patients", new PatientsModule(new Repository<Patient>()) },
            { "offices", new OfficesModule(new Repository<Office>()) },
            { "hours", new OfficeHoursModule(new Repository<WeeklyOfficeHours>()) }
        };

        static void Main(string[] args)
        {
            var module = moduleMap[args[0]];
            module.Execute(args);
        }
    }
}
