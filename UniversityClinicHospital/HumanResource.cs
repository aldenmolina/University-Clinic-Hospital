using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class HumanResource
    {
        public static Doctor doctor;
        public static Nurse nurse;
        public static Receptionist receptionist;
        public static Janitor janitor;
        public static Patient patient;
        
        public HumanResource()
        {
            patient = new Patient();
            doctor = new Doctor();
            nurse = new Nurse();
            receptionist = new Receptionist();
            janitor = new Janitor();
        }

        public void Patient()
        {
            patient.PatientStatus();
            Console.ReadKey();
        }

        public void ListEmployeeStatus()
        {
            Console.Clear();
            doctor.Status();
            Console.WriteLine();
            nurse.Status();
            Console.WriteLine();
            receptionist.Status();
            Console.WriteLine();
            janitor.Status();

            Console.WriteLine();
            Console.WriteLine("Press ANY key to go back to Main Menu.");
            Console.ReadKey();
        }

        public void EmployeeActions()
        {
            Console.Clear();
            Console.WriteLine("Which employee would you like to put to work?");
            Console.WriteLine("1. Doctor.");
            Console.WriteLine("2. Nurse.");
            Console.WriteLine("3. Receptionist.");
            Console.WriteLine("4. Janitor.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    doctor.DoctorActions(patient);
                    break;
                case "2":
                    nurse.NurseActions(patient);
                    break;
                case "3":
                    receptionist.Phone();
                    break;
                case "4":
                    janitor.Sweep();
                    break;
            }
        }

        public void EmployeePayments()
        {
            Console.Clear();
            Console.WriteLine("Which employee would you like to pay?");
            Console.WriteLine("1. Doctor.");
            Console.WriteLine("2. Nurse.");
            Console.WriteLine("3. Receptionist.");
            Console.WriteLine("4. Janitor.");
            Console.WriteLine("5. Pay All");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    doctor.PayEmployee();
                    Console.ReadKey();
                    EmployeePayments();
                    break;
                case "2":
                    nurse.PayEmployee();
                    Console.ReadKey();
                    EmployeePayments();
                    break;
                case "3":
                    receptionist.PayEmployee();
                    Console.ReadKey();
                    EmployeePayments();
                    break;
                case "4":
                    janitor.PayEmployee();
                    Console.ReadKey();
                    EmployeePayments();
                    break;
                case "5":
                    doctor.PayEmployee();
                    nurse.PayEmployee();
                    receptionist.PayEmployee();
                    janitor.PayEmployee();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
