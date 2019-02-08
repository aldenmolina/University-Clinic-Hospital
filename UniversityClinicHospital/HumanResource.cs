using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class HumanResource
    {
        public static List<Employee> employees { get; private set; }
        public static Doctor doctor;
        public static Nurse nurse;
        public static Receptionist receptionist;
        public static Janitor janitor;
        
        public HumanResource()
        {
            employees.Add(doctor);
            employees.Add(nurse);
            employees.Add(receptionist);
            employees.Add(janitor);
        }

        public void ListEmployees()
        {
            int listNumber = 0;
            foreach(Employee emp in employees)
            {
                Console.WriteLine((listNumber + 1) + ". Name: " + emp.Name);
                Console.WriteLine("   Position: " + emp.Position);
            }

            Console.WriteLine();
            Console.WriteLine("Press ANY key to go back to Main Menu.");
            Console.ReadKey();
        }

        public void ListEmployeeStatus()
        {
            int listNumber = 0;
            foreach (Employee emp in employees)
            {
                Console.WriteLine((listNumber + 1) + ".)");
                emp.Status();
            }

            Console.WriteLine();
            Console.WriteLine("Press ANY key to go back to Main Menu.");
            Console.ReadKey();
        }

        public void EmployeeActions()
        {
            Console.WriteLine("")
        }
    }
}
