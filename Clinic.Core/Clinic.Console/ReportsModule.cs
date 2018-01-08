using Clinic.Core.Reports;
using Clinic.DataAccess;
using System;
using System.Linq;
using Clinic.Core;

namespace Clinic.Console
{
    public class ReportsModule : IModule
    {
        ConsultationsRepository repository;

        public ReportsModule()
        {
            repository = new ConsultationsRepository();
        }

        public void Execute(string[] args)
        {
            switch (args[1])
            {
                case "clinic": ViewClinicActivity(args); break;
                case "doctor": ViewDoctorActivity(args); break;
                case "office": ViewOfficeActivity(args); break;
            }
        }

        private void ViewClinicActivity(string[] args)
        {
            var startDateTime = DateTime.Parse(args[2]);
            var endDateTime = DateTime.Parse(args[3]);

            var report = ClinicActivityReport.For(repository, startDateTime, endDateTime);

            System.Console.WriteLine("Total visits duration: {0}", report.TotalVisitsDuration);
            System.Console.WriteLine("Total amount received: ${0}", report.TotalAmountReceived);
        }

        private void ViewDoctorActivity(string[] args)
        {
            var doctor = GetDoctorByName(args[2]);
            var startDateTime = DateTime.Parse(args[3]);
            var endDateTime = DateTime.Parse(args[4]);
            
            var report = DoctorActivityReport.For(repository, doctor, startDateTime, endDateTime);

            System.Console.WriteLine("Total visits: {0}", report.ClinicalVisitsCount);
            System.Console.WriteLine("Total amount received: ${0}", report.TotalAmountReceived);
        }

        private Doctor GetDoctorByName(string doctorName)
        {
            var doctorRepository = new Repository<Doctor>();
            return doctorRepository.Search(doctor => doctor.Name == doctorName).Single();
        }

        private void ViewOfficeActivity(string[] args)
        {
            var office = GetOfficeByLocation(args[2]);
            var startDateTime = DateTime.Parse(args[3]);
            var endDateTime = DateTime.Parse(args[4]);

            var report = OfficeActivityReport.For(repository, office, startDateTime, endDateTime);

            System.Console.WriteLine("Total visits duration: {0}", report.TotalVisitDuration);
        }

        private Office GetOfficeByLocation(string officeLocation)
        {
            var officeRepository = new Repository<Office>();
            return officeRepository.Search(office => office.Location == officeLocation).Single();
        }
    }
}
