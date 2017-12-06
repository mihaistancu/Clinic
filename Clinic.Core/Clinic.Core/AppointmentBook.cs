using System.Collections.Generic;

namespace Clinic.Core
{
    public class AppointmentBook
    {
        private readonly List<Appointment> appointments;

        public AppointmentBook()
        {
            appointments = new List<Appointment>();
        }

        public void Schedule(Appointment appointment)
        {
            appointments.Add(appointment);
        }
    }
}
