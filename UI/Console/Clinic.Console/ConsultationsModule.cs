using System;
using Clinic.Data.Persistence;

namespace Clinic.Console
{
    public class ConsultationsModule : Module
    {
        readonly ConsultationsRepository repository;

        public ConsultationsModule(ConsultationsRepository repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            string doctorName = args[2];
            string officeLocation = args[3];
            string patientName = args[4];
            DateTime startDateTime = DateTime.Parse(args[5]);
            DateTime endDateTime = DateTime.Parse(args[6]);
            double amountReceived = double.Parse(args[7]);
            repository.Add(doctorName, officeLocation, patientName, startDateTime, endDateTime, amountReceived);
        }

        protected override void List()
        {
            foreach(var consultation in repository.GetAll())
            {
                System.Console.WriteLine("Dr {0} - {1}", consultation.Doctor.Name, consultation.Office.Location);
                System.Console.WriteLine("Patient: {0}", consultation.Patient.Name);
                System.Console.WriteLine("{0} - {1}", consultation.StartDateTime, consultation.EndDateTime);
                System.Console.WriteLine("${0}", consultation.AmountReceived);
            }
        }
    }
}
