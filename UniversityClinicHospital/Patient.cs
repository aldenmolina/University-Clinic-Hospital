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

        public void BloodDrawn()
        {
            BloodLevel -= 10;
            Limit();
        }

        public void Treated()
        {
            HealthLevel += 20;
            Limit();
        }

        public void CaredFor()
        {
            HealthLevel += 10;
            BloodLevel += 10;
            Limit();
        }

        public void Limit()
        {
            if (HealthLevel > 100)
            {
                HealthLevel = 100;
            }
            if (BloodLevel > 100)
            {
                BloodLevel = 100);
            }
            if (HealthLevel < 0)
            {
                HealthLevel = 0;
            }
            if (BloodLevel < 0)
            {
                BloodLevel = 0;
            }
        }
    }
}
