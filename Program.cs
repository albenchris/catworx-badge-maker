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
                // giving some space
                Console.WriteLine(" ");

                Console.Write("Enter first name (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "")
                {
                    break;
                }

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("Enter photo URL: ");
                string photoUrl = Console.ReadLine();

                // Create a new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            return employees;
        }

        // ===================================================================
        

        // ===================================================================

        // Entry Point
        static void Main(string[] args)
        // ALSO, THIS => static void Main()
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
        }

        // ===================================================================
    }
}
