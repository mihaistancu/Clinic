namespace Clinic.Console
{
    class Program
    {
        static void Main(string[] args)
        {            
            string module = args[0];
            
            if (module == "doctors")
            {
                var doctorsModule = new DoctorsModule();
                doctorsModule.Execute(args);
                return;
            }

            if (module == "patients")
            {
                var patientsModule = new PatientsModule();
                patientsModule.Execute(args);
                return;
            }

            if (module == "offices")
            {
                var officesModule = new OfficesModule();
                officesModule.Execute(args);
                return;
            }

            System.Console.WriteLine("Unknown operation");
        }
    }
}
