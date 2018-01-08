using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clinic.Core;

namespace Clinic.Tests
{
    [TestClass]
    public class AppointmentsTests
    {
        [TestMethod]
        public void CanCreateAnAppointment()
        {
            var appointment = new Appointment
            {
                Doctor = new Doctor { Name = "Doctor" },
                StartDate = new DateTime(2010, 01, 01, 10, 30, 0)
            };
        }
    }
}
