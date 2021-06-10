using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
        // ALSO, THIS...
        // static void Main() // Entry Point
        {
            List<string> employees = new List<string>() { "adam", "amy" };

            employees.Add("barbara");
            employees.Add("billy");

            Console.WriteLine("My employees are:");
            for (int i=0; i<employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
