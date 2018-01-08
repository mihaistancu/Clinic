using System;
using System.Linq.Expressions;

namespace Clinic.Data.Persistence
{
    public class Filter 
    {
        public static Expression<Func<ClinicalVisit, bool>> ByOffice(Office office)
        {
            return visit => visit.Office.Location == office.Location;
        }

        public static Expression<Func<ClinicalVisit, bool>> ByDoctor(Doctor doctor)
        {
            return visit => visit.Doctor.Name == doctor.Name;
        }

        public static Expression<Func<ClinicalVisit, bool>> ByTimeframe(DateTime startDateTime, DateTime endDateTime)
        {
            return visit =>
                visit.StartDateTime >= startDateTime &&
                visit.EndDateTime <= endDateTime;
        }

        public static Expression<Func<ClinicalVisit, bool>> ByDate(DateTime date)
        {
            return visit => visit.StartDateTime.Date == date.Date;
        }
    }
}
