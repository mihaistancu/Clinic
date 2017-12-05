using System;
using System.Collections.Generic;
using Clinic.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clinic.Tests
{
    [TestClass]
    public class SchedulingTests
    {
        [TestMethod]
        public void Foo()
        {
            var schedule = new Schedule
            {
                Doctor = new Doctor
                {
                    Name = "Doctor",
                    Practices = new List<Practice>
                    {
                        new Practice {Title = "Practice1"},
                        new Practice {Title = "Practice2"}
                    }
                },
                Office = new Office { Location = "Location" },
                OfficeHours = new List<Availability>
                {
                    new Availability
                    {
                        DayOfWeek = DayOfWeek.Monday,
                        StartTime = TimeSpan.Parse("08:00"),
                        EndTime = TimeSpan.Parse("18:00")
                    },
                    new Availability
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
