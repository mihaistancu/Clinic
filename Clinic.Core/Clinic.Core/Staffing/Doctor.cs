﻿using System.Collections.Generic;

namespace Clinic.Core.Staffing
{
    public class Doctor
    {
        public string Name { get; set; }

        public List<Practice> Practices { get; set; }
    }
}