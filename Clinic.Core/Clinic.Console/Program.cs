using System.Collections.Generic;

namespace Clinic.Console
{
    class Program
    {
        static Dictionary<string, IModule> moduleMap = new Dictionary<string, IModule>
        {
            { "doctors", new DoctorsModule() },
            { "patients", new PatientsModule() },
            { "offices", new OfficesModule() },
            { "hours", new OfficeHoursModule() }
        };

        static void Main(string[] args)
        {
            var module = moduleMap[args[0]];
            module.Execute(args);
        }
    }
}
