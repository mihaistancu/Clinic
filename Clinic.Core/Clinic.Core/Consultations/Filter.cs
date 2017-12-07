using System;

namespace Clinic.Core.Consultations
{
    public class Filter 
    {
        public static Func<ClinicalVisit, bool> ByOffice(Office office)
        {
            return visit => visit.Office == office;
        }

        public static Func<ClinicalVisit, bool> ByDoctor(Doctor doctor)
        {
            return visit => visit.Doctor == doctor;
        }

        public static Func<ClinicalVisit, bool> ByTimeframe(DateTime startDateTime, DateTime endDateTime)
        {
            return visit =>
                visit.StartDateTime >= startDateTime &&
                visit.EndDateTime <= endDateTime;
        }

        public static Func<ClinicalVisit, bool> ByDate(DateTime date)
        {
            return visit => visit.StartDateTime.Date == date.Date;
        }
    }
}
