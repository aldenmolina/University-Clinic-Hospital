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
        public void DoctorActions(Patient patient)
        {
            Console.Clear();
            Console.WriteLine("What to do with doctor?");
            Console.WriteLine("1. Draw Blood.");
            Console.WriteLine("2. Treat.");
            Console.WriteLine("3. Go back to Main Menu.");
            string doctorAction = Console.ReadLine();
            switch (doctorAction)
            {
                case "1":
                    DrawBlood(patient);
                    break;
                case "2":
                    Treat(patient);
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Please choose a valid selection.");
                    Console.ReadKey();
                    break;
            }
        }

        public void DrawBlood(Patient patient)
        {
            patient.BloodDrawn();
            Console.WriteLine("You drew blood!");
            Console.WriteLine("Patient blood level is now " + patient.BloodLevel);
            Console.ReadKey();
           
        }

        public void Treat(Patient patient)
        {
            patient.Treated();
            Console.WriteLine("You treated the patient!");
            Console.WriteLine("Patient health level is now " + patient.HealthLevel);
            Console.ReadKey();
        }
    }
}
