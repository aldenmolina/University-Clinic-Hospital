using System;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResource hr = new HumanResource();
            Menu menu = new Menu();

            menu.MainMenu(hr);
        }
    }
}
