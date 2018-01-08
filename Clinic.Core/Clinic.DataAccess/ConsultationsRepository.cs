using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Clinic.Data.Persistence
{
    public class ConsultationsRepository: Repository<ClinicalVisit>
    {
        public void Add(string doctorName, string officeLocation, string patientName, DateTime startDateTime, DateTime endDateTime, double amountReceived)
        {
            using (var context = new ClinicDbContext())
            {
                var doctor = context.Doctors.Single(d => d.Name == doctorName);
                var office = context.Offices.Single(d => d.Location == officeLocation);
                var patient = context.Patients.Single(d => d.Name == patientName);
                context.Consultations.Add(new ClinicalVisit
                {
                    Doctor = doctor,
                    Office = office,
                    Patient = patient,
                    StartDateTime = startDateTime,
                    EndDateTime = endDateTime,
                    AmountReceived = amountReceived
                });
                context.SaveChanges();
            }
        }

        public override List<ClinicalVisit> GetAll()
        {
            using (var context = new ClinicDbContext())
            {
                return context.Consultations
                    .Include(a => a.Doctor)
                    .Include(a => a.Office)
                    .Include(a => a.Patient)
                    .ToList();
            }
        }

        public override List<ClinicalVisit> Search(params Expression<Func<ClinicalVisit, bool>>[] predicates)
        {
            using (var context = new ClinicDbContext())
            {
                IQueryable<ClinicalVisit> results = context.Consultations
                    .Include(a => a.Doctor)
                    .Include(a => a.Office)
                    .Include(a => a.Patient);

                foreach (var predicate in predicates)
                {
                    results = results.Where(predicate);
                }

                return results.ToList();
            }
        }
    }
}
