using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Clinic.Data.Persistence.EF
{
    public class OfficeHoursRepository : Repository<OfficeHours>
    {
        public void Add(string doctorName, string officeLocation, DayOfWeek dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            using (var context = new ClinicDbContext())
            {
                var doctor = context.Doctors.Single(d => d.Name == doctorName);
                var office = context.Offices.Single(o => o.Location == officeLocation);
                context.OfficeHours.Add(new OfficeHours
                {
                    Doctor = doctor,
                    Office = office,
                    DayOfWeek = dayOfWeek,
                    StartTime = startTime,
                    EndTime = endTime
                });
                context.SaveChanges();
            }
        }

        public override List<OfficeHours> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.OfficeHours
                    .Include(o => o.Doctor)
                    .Include(o => o.Office)
                    .ToList();
            }
        }

        public override List<OfficeHours> Search(params Expression<Func<OfficeHours, bool>>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                IQueryable<OfficeHours> results = context.OfficeHours
                    .Include(o => o.Doctor)
                    .Include(o => o.Office);

                foreach (var predicate in predicates)
                {
                    results = results.Where(predicate);
                }

                return results.ToList();
            }
        }
    }
}
