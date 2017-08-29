using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee list from 3rd party organization system.");
            Console.WriteLine("-------------------------------------------------");

            // Client will use ITarget interface to call functionality of 
            // Adaptee class i.e. ThirdPartyEmployee
            ITarget adapter = new EmployeeAdapter();

            foreach (string employee in adapter.GetEmployees())
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }

    // Adaptee Class
    class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>();
            EmployeeList.Add("Peter");
            EmployeeList.Add("Paul");
            EmployeeList.Add("Puru");
            EmployeeList.Add("Preethi");
            return EmployeeList;
        }
    }

    // ITarget Class
    interface ITarget
    {
        List<string> GetEmployees();
    }

    // Adapter class
    class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
}
