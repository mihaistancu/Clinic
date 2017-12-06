using Clinic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Clinic.Tests
{
    [TestClass]
    public class AppointmentBookTests
    {
        [TestMethod]
        public void CanCreateAnAppointment()
        {
            var appointmentBook = new AppointmentBook { Appointments = new List<Appointment>() };
            appointmentBook.Appointments.Add(new Appointment
            {
                Doctor = new Doctor { Name = "Doctor" },
                StartDate = new DateTime(2010, 01, 01, 10, 30, 0)
            });
        }
    }
}
