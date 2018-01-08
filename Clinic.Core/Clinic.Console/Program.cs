using System.Collections.Generic;
using Clinic.Data;
using Clinic.Data.Persistence;

namespace Clinic.Console
{
    class Program
    {
        static Dictionary<string, IModule> moduleMap = new Dictionary<string, IModule>
        {
            { "doctors", new DoctorsModule(new Repository<Doctor>()) },
            { "patients", new PatientsModule(new Repository<Patient>()) },
            { "offices", new OfficesModule(new Repository<Office>()) },
            { "hours", new OfficeHoursModule(new OfficeHoursRepository()) },
            { "appointments", new AppointmentsModule(new AppointmentsRepository()) },
            { "consultations", new ConsultationsModule(new ConsultationsRepository()) },
            { "reports", new ReportsModule() }
        };

        static void Main(string[] args)
        {
            var module = moduleMap[args[0]];
            module.Execute(args);
        }
    }
}
