using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Menu
    {
        public void MainMenu(HumanResource hr)
        {
            Console.Clear();
            Console.WriteLine("======MAIN MENU======");
            Console.WriteLine("1. List of Employees.");
            Console.WriteLine("2. Employee Actions.");
            Console.WriteLine("3. Pay Employees.");
            Console.WriteLine("4. Check patient Status");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    hr.ListEmployeeStatus();
                    MainMenu(hr);
                    break;
                case "2":
                    hr.EmployeeActions();
                    MainMenu(hr);
                    break;
                case "3":
                    hr.EmployeePayments();
                    MainMenu(hr);
                    break;
                case "4":
                    hr.Patient();
                    MainMenu(hr);
                    break;
                default:
                    Console.WriteLine("Please choose a valid selection.");
                    Console.ReadKey();
                    break;

            }
        }
        

    }
}
