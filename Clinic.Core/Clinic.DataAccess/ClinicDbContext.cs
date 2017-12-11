using System.Data.Entity;
using Clinic.Core.Staffing;

namespace Clinic.DataAccess
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() : base("Clinic")
        {
        }

        public DbSet<Doctor> Doctors { get; set; } 
    }
}
