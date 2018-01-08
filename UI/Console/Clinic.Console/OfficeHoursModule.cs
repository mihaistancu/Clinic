using System;
using System.Linq;
using Clinic.Data.Persistence.EF;

namespace Clinic.Console
{
    public class OfficeHoursModule : Module
    {
        readonly OfficeHoursRepository repository;

        public OfficeHoursModule(OfficeHoursRepository repository)
        {
            this.repository = repository;
        }

        protected override void Add(string[] args)
        {
            var doctorName = args[2];
            var officeLocation = args[3];
            var dayOfWeek = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), args[4]);
            var startTime = TimeSpan.Parse(args[5]);
            var endTime = TimeSpan.Parse(args[6]);
            repository.Add(doctorName, officeLocation, dayOfWeek, startTime, endTime);
        }

        protected override void List()
        {
            var results = repository.GetAll()
                .OrderBy(h => h.Doctor)
                .ThenBy(h => h.Office)
                .ThenBy(h => h.DayOfWeek);

            foreach (var item in results)
            {
                System.Console.WriteLine("Dr. {0}, {1} {2} {3} {4}", item.Doctor.Name, item.Office.Location, item.DayOfWeek, item.StartTime, item.EndTime);
            }
        }
    }
}
