using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
                                        // ALSO, THIS => static void Main() // Entry Point

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
                employees.Add(input);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
