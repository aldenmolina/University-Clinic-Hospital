﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; private set; }

        public override void PaySalary()
        {
            PayNurse();
        }
    }
}
