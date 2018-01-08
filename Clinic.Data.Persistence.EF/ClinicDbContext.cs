using System.Data.Entity;

namespace Clinic.Data.Persistence.EF
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() : base("Clinic")
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<OfficeHours> OfficeHours { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Examination> Examinations { get; set; }
    }
}
