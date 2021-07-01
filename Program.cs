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
        static void PrintEmployees(List<Employee> employees)
        {
            // giving some space
            Console.WriteLine(" ");

            Console.WriteLine("Employees:");
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
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
