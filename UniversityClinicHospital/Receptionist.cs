using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; private set; }

        public override void PaySalary()
        {
            PayReceptionist();
        }

    }
}
