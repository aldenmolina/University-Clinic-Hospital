using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public int HealthLevel { get; private set; }
        public int BloodLevel { get; private set; }

        public Patient()
        {
            HealthLevel = 10;
            BloodLevel = 20;
        }

    }
}
