using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public bool Paid { get; set; }

        public Employee()
        {
            Paid = false;
        }

        public abstract void Status();

        public abstract void PayEmployee();
        

    }
}
