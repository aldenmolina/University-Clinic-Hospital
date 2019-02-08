using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Menu
    {
        public void MainMenu(HumanResource hr)
        {
            Console.WriteLine("======MAIN MENU======");
            Console.WriteLine("1. List of Employees.");
            Console.WriteLine("2. Employee Status.");
            Console.WriteLine("3. Employee Actions.");
            Console.WriteLine("4. Pay Employees.");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    hr.ListEmployees();
                    MainMenu(hr);
                    break;
                case "2":
                    hr.ListEmployeeStatus();
                    MainMenu(hr);
                    break;
                case "3":
                    //add list of employee actions.
                    MainMenu(hr);
                    break;
                case "4":
                    //add payment method to pay employees
                    MainMenu(hr);
                    break;
            }
        }
        

    }
}
