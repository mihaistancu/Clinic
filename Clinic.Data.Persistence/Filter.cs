using System;
using System.Linq.Expressions;

namespace Clinic.Data.Persistence
{
    public class Filter 
    {
        public static Expression<Func<Examination, bool>> ByOffice(Office office)
        {
            return e => e.Office.Location == office.Location;
        }

        public static Expression<Func<Examination, bool>> ByDoctor(Doctor doctor)
        {
            return e => e.Doctor.Name == doctor.Name;
        }

        public static Expression<Func<Examination, bool>> ByTimeframe(DateTime startDateTime, DateTime endDateTime)
        {
            return e => e.StartDateTime >= startDateTime && e.EndDateTime <= endDateTime;
        }

        public static Expression<Func<Examination, bool>> ByDate(DateTime date)
        {
            return e => e.StartDateTime.Date == date.Date;
        }
    }
}
