using System.Data.Entity;
using Clinic.Core.Staffing;

namespace Clinic.DataAccess
{
    public class ClinicDbContext
    {
        public DbSet<Doctor> Doctors { get; set; } 
    }
}
