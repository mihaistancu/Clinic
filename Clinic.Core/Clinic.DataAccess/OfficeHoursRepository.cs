using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Clinic.Data.OfficeHours;

namespace Clinic.Data.Persistence
{
    public class OfficeHoursRepository : Repository<WeeklyOfficeHours>
    {
        public void Add(string doctorName, string officeLocation, DailyOfficeHours officeHours)
        {
            using (var context = new ClinicDbContext())
            {
                var existingHours = context.OfficeHours.Include(h => h.OfficeHours)
                    .SingleOrDefault(h => h.Doctor.Name == doctorName && h.Office.Location == officeLocation);

                if (existingHours == null)
                {
                    existingHours = CreateOfficeHours(context, doctorName, officeLocation);
                }

                existingHours.OfficeHours.Add(officeHours);
                context.SaveChanges();
            }
        }

        private WeeklyOfficeHours CreateOfficeHours(ClinicDbContext context, string doctorName, string officeLocation)
        {
            var doctor = context.Doctors.Single(d => d.Name == doctorName);
            var office = context.Offices.Single(o => o.Location == officeLocation);
            return context.OfficeHours.Add(new WeeklyOfficeHours { Doctor = doctor, Office = office, OfficeHours = new List<DailyOfficeHours>() });
        }

        public override List<WeeklyOfficeHours> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.OfficeHours
                    .Include(o => o.Doctor)
                    .Include(o => o.Office)
                    .Include(o => o.OfficeHours)
                    .ToList();
            }
        }

        public override List<WeeklyOfficeHours> Search(params Expression<Func<WeeklyOfficeHours, bool>>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                IQueryable<WeeklyOfficeHours> results = context.OfficeHours
                    .Include(o => o.Doctor)
                    .Include(o => o.Office)
                    .Include(o => o.OfficeHours);

                foreach (var predicate in predicates)
                {
                    results = results.Where(predicate);
                }

                return results.ToList();
            }
        }
    }
}
