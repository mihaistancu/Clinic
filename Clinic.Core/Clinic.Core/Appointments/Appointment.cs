﻿using System;

namespace Clinic.Core.Appointments
{
    public class Appointment
    {
        public Doctor Doctor { get; set; }
        public DateTime StartDate { get; set; }
    }
}