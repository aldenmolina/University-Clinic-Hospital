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
        public string Salary { get; private set; }
        public bool Paid { get; private set; }

        public Employee()
        {
            Paid = false;
        }
        public abstract void PaySalary();

        public abstract void Status();

        public void PayDoctor()
        {
            Console.WriteLine("Doctor has been paid $90,000.00 for salary.");
            Salary += 90000;
            Paid = true;
        }

        public void PayNurse()
        {
            Console.WriteLine("Nurse has been paid $50,000.00 for salary.");
            Salary += 50000;
            Paid = true;
        }

        public void PayReceptionist()
        {
            Console.WriteLine("Receptionist has been paid $45,000.00 for salary.");
            Salary += 45000;
            Paid = true;
        }

        public void PayJanitor()
        {
            Console.WriteLine("Janitor has been paid $40,000.00 for salary.");
            Salary += 40000;
            Paid = true;
        }

        

    }
}
