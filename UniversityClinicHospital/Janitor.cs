using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; private set; }

        public Janitor()
        {
            Name = "Tom Hanks";
            EmployeeNumber = 44044;
            Sweeping = false;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                PayJanitor();
            }
            else
            {
                Console.WriteLine("Already paid salary for the session.");
            }
        }

        public override void Status()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("EmployeeNumber: " + EmployeeNumber);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Currently on Sweeping: " + Sweeping);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Paid Status: " + Paid);

        }
    }
}
