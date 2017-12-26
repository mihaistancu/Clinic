using Clinic.DataAccess;
using System;

namespace Clinic.Console
{
    public class AppointmentsModule : Module
    {
        AppointmentsRepository repository;
        
        public AppointmentsModule(AppointmentsRepository repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            var doctorName = args[2];
            var startDateTime = DateTime.Parse(args[3]);
            repository.Add(doctorName, startDateTime);
        }

        protected override void List()
        {
            foreach(var appointment in repository.GetAll())
            {
                System.Console.WriteLine("Dr. {0}: {1}", appointment.Doctor.Name, appointment.StartDate);
            }
        }
    }
}
