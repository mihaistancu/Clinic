﻿using System;
using System.Linq;
using Clinic.Data;
using Clinic.Data.Persistence.EF;
using Clinic.Reports;

namespace Clinic.Console
{
    public class ReportsModule : IModule
    {
        readonly ExaminationsRepository repository;

        public ReportsModule()
        {
            repository = new ExaminationsRepository();
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

            System.Console.WriteLine("Total examinations duration: {0}", report.TotalExaminationsDuration);
            System.Console.WriteLine("Total amount received: ${0}", report.TotalAmountReceived);
        }

        private void ViewDoctorActivity(string[] args)
        {
            var doctor = GetDoctorByName(args[2]);
            var startDateTime = DateTime.Parse(args[3]);
            var endDateTime = DateTime.Parse(args[4]);
            
            var report = DoctorActivityReport.For(repository, doctor, startDateTime, endDateTime);

            System.Console.WriteLine("Total examinations: {0}", report.ExaminationsCount);
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

            System.Console.WriteLine("Total examinations duration: {0}", report.TotalExaminationsDuration);
        }

        private Office GetOfficeByLocation(string officeLocation)
        {
            var officeRepository = new Repository<Office>();
            return officeRepository.Search(office => office.Location == officeLocation).Single();
        }
    }
}
