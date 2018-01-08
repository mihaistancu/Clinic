using System.Data.Entity;
using Clinic.Core;
using Clinic.Core.OfficeHours;
using Clinic.Core.Consultations;

namespace Clinic.DataAccess
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() : base("Clinic")
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<WeeklyOfficeHours> OfficeHours { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<ClinicalVisit> Consultations { get; set; }
    }
}
