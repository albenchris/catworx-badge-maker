using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // =================================================================
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();

            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee.GetName());
            }
            return employees;
        }

        // ===================================================================
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        // ===================================================================

        // Entry Point
        static void Main(string[] args)
        // ALSO, THIS => static void Main() // Entry Point
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }

        // ===================================================================
    }
}
