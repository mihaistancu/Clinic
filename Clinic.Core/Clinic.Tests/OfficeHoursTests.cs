using System;
using System.Collections.Generic;
using Clinic.Core.Staffing;
using Clinic.Core.Infrastructure;
using Clinic.Core.OfficeHours;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clinic.Tests
{
    [TestClass]
    public class OfficeHoursTests
    {
        [TestMethod]
        public void CanCreateOfficeHours()
        {
            var weeklyOfficeHours = new WeeklyOfficeHours
            {
                Doctor = new Doctor
                {
                    Name = "Doctor"
                },
                Office = new Office { Location = "Location" },
                OfficeHours = new List<DailyOfficeHours>
                {
                    new DailyOfficeHours
                    {
                        DayOfWeek = DayOfWeek.Monday,
                        StartTime = TimeSpan.Parse("08:00"),
                        EndTime = TimeSpan.Parse("18:00")
                    },
                    new DailyOfficeHours
                    {
                        DayOfWeek = DayOfWeek.Tuesday,
                        StartTime = TimeSpan.Parse("09:00"),
                        EndTime = TimeSpan.Parse("19:00")
                    }
                }
            };
        }
    }
}
