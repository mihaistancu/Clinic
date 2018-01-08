using System;
using Clinic.Data.Persistence.EF;

namespace Clinic.Console
{
    public class ExaminationsModule : Module
    {
        readonly ExaminationsRepository repository;

        public ExaminationsModule(ExaminationsRepository repository)
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
            foreach(var examination in repository.GetAll())
            {
                System.Console.WriteLine("Dr {0} - {1}", examination.Doctor.Name, examination.Office.Location);
                System.Console.WriteLine("Patient: {0}", examination.Patient.Name);
                System.Console.WriteLine("{0} - {1}", examination.StartDateTime, examination.EndDateTime);
                System.Console.WriteLine("${0}", examination.AmountReceived);
            }
        }
    }
}
