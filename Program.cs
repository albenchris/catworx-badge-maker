using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // =================================================================
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee);
            }
            return employees;
        }

        // ===================================================================
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            }
        }

        // ===================================================================

        // Entry Point
        static void Main(string[] args)
        // ALSO, THIS => static void Main() // Entry Point
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }

        // ===================================================================
    }
}
