using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; private set; }

        public override void PaySalary()
        {
            PayJanitor();
        }

    }
}
