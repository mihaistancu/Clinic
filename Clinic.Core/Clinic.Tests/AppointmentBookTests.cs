using Clinic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Core.Appointments;

namespace Clinic.Tests
{
    [TestClass]
    public class AppointmentBookTests
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
