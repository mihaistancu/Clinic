﻿using System;
using Clinic.Core.Staffing;

namespace Clinic.Core.Appointments
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
    }
}
