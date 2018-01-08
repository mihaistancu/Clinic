using System;
using System.Linq;
using Clinic.Data.OfficeHours;
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
            var officeHours = new DailyOfficeHours
            {
                DayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), args[4]),
                StartTime = TimeSpan.Parse(args[5]),
                EndTime = TimeSpan.Parse(args[6])
            };
            repository.Add(doctorName, officeLocation, officeHours);
        }

        protected override void List()
        {
            foreach (var item in repository.GetAll())
            {
                System.Console.WriteLine("Dr. {0}, {1}", item.Doctor.Name, item.Office.Location);

                foreach (var hours in item.OfficeHours.OrderBy(h => h.DayOfWeek))
                {
                    System.Console.WriteLine("{0}: {1} - {2}", hours.DayOfWeek, hours.StartTime, hours.EndTime);
                }
            }
        }
    }
}
