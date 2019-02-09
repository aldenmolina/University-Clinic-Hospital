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

        public override void PayEmployee()
        {
            if (Paid == false)
            {
                Console.WriteLine("Nurse has been paid $40,000.00 for salary.");
                Salary += 50000;
                Paid = true;
            }
            else { Console.WriteLine("Employee already paid for this session."); }
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

        public void NurseActions(Patient patient)
        {
            Console.Clear();
            Console.WriteLine("What to do with nurse?");
            Console.WriteLine("1. Draw Blood.");
            Console.WriteLine("2. Care.");
            Console.WriteLine("3. Go back to Main Menu.");
            string doctorAction = Console.ReadLine();
            switch (doctorAction)
            {
                case "1":
                    DrawBlood(patient);
                    break;
                case "2":
                    Care(patient);
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
            Console.WriteLine("Blood Level increased to " + patient.BloodLevel);
            Console.ReadKey();
        }

        public void Care(Patient patient)
        {
            patient.CaredFor();
            Console.WriteLine("You cared for the patient!");
            Console.WriteLine("Patient blood level is now " + patient.BloodLevel);
            Console.WriteLine("Patient health level is now " + patient.HealthLevel);
            Console.ReadKey();
        }
    }
}
