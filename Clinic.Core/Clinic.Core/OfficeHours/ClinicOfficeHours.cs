using System.Collections.Generic;

namespace Clinic.Core.OfficeHours
{
    public class ClinicOfficeHours
    {
        private readonly List<WeeklyOfficeHours> officeHours;

        public ClinicOfficeHours()
        {
            officeHours = new List<WeeklyOfficeHours>();
        }

        public void Add(WeeklyOfficeHours weeklyOfficeHours)
        {
            officeHours.Add(weeklyOfficeHours);
        }
    }
}
