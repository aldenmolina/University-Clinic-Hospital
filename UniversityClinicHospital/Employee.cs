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
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public Employee()
        {
            Paid = false;
            Salary = 0;
        }

        public abstract void Status();

        public abstract void PayEmployee();
        

    }
}
