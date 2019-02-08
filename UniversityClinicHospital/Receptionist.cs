using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; private set; }

        public Receptionist()
        {
            Name = "Marylin Monroe";
            EmployeeNumber = 33033;
            OnPhone = false;
        }

        public override void PayEmployee()
        {
            if (Paid == false)
            {
            Console.WriteLine("Receptionist has been paid $40,000.00 for salary.");
            Salary += 45000;
            Paid = true;
            }
            else { Console.WriteLine("Employee already paid for this session."); }
        }

        public override void Status()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("EmployeeNumber: " + EmployeeNumber);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Currently on Phone: " + OnPhone);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Paid Status: " + Paid);

        }
    }
}
