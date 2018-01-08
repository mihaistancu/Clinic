using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using Clinic.Core;
using Clinic.Core.OfficeHours;

namespace Clinic.DataAccess
{
    public class AppointmentsRepository: Repository<Appointment>
    {
        public void Add(string doctorName, DateTime startDateTime)
        {
            using (var context = new ClinicDbContext())
            {
                var doctor = context.Doctors.Single(d => d.Name == doctorName);
                context.Appointments.Add(new Appointment { Doctor = doctor, StartDate = startDateTime });
                context.SaveChanges();
            }
        }

        public override List<Appointment> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Appointments.Include(a => a.Doctor).ToList();
            }
        }

        public override List<Appointment> Search(params Expression<Func<Appointment, bool>>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                IQueryable<Appointment> results = context.Appointments
                    .Include(o => o.Doctor);
                    
                foreach (var predicate in predicates)
                {
                    results = results.Where(predicate);
                }

                return results.ToList();
            }
        }
    }
}
