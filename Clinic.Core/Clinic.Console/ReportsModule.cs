using Clinic.Core.Reports;
using Clinic.DataAccess;
using System;

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
            }
        }

        private void ViewClinicActivity(string[] args)
        {
            var startDateTime = DateTime.Parse(args[2]);
            var endDateTime = DateTime.Parse(args[3]);

            var report = ClinicActivityReport.For(repository, startDateTime, endDateTime);

            System.Console.WriteLine("Total visits duration: {0}", report.TotalVisitsDuration);
            System.Console.WriteLine("Total amount received: {0}", report.TotalAmountReceived);
        }
    }
}
