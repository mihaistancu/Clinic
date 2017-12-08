using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Core.Appointments;
using Clinic.Core.Staffing;

namespace Clinic.Tests
{
    [TestClass]
    public class AppointmentsTests
    {
        [TestMethod]
        public void CanCreateAnAppointment()
        {
            var appointmentBook = new AppointmentBook();
            appointmentBook.Schedule(new Appointment
            {
                Doctor = new Doctor { Name = "Doctor" },
                StartDate = new DateTime(2010, 01, 01, 10, 30, 0)
            });
        }
    }
}
