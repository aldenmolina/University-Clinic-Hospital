using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; private set; }

        public override void PaySalary()
        {
            PayDoctor();
        }
    }
}
