using System.Data.Entity;
using Clinic.Core.Infrastructure;
using Clinic.Core.Patients;
using Clinic.Core.Staffing;

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
    }
}
