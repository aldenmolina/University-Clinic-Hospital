using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; private set; }

        public Doctor()
        {
            Name = "Billy Bob";
            EmployeeNumber = 110011;
            Position = "Doctor";
            Specialty = "Butt Doctor";
        }

        public override void PayEmployee()
        {
            if (Paid == false)
            {
            Console.WriteLine("Doctor has been paid $40,000.00 for salary.");
            Salary += 90000;
                Paid = true;
            }
            else { Console.WriteLine("Employee already paid for this session."); }
        }

        public override void Status()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("EmployeeNumber: " + EmployeeNumber);
            Console.WriteLine("Position: " + Position);
            Console.WriteLine("Specialy: " + Specialty);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Paid Status: " + Paid);

        }

        public void DrawBlood(Patient patient)
        {
            patient.BloodDrawn();
        }

        public void Treat(Patient patient)
        {
            patient.Treated();
        }
    }
}
