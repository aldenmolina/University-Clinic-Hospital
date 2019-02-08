using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; private set; }

        public Nurse()
        {
            Random random = new Random();

            Name = "George Michael";
            EmployeeNumber = 22022;
            NumberOfPatients = random.Next(5, 20);
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                PayNurse();
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
            Console.WriteLine("Number of Patients: " + NumberOfPatients);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Paid Status: " + Paid);

        }

        public void DrawBlood(Patient patient)
        {
            patient.BloodDrawn();
        }

        public void Care(Patient patient)
        {
            patient.CaredFor();
        }
    }
}
