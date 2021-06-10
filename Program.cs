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

            Console.WriteLine(
                "My employees include {0}, {1}, {2}, {3}",
                employees[0],
                employees[1],
                employees[2],
                employees[3]
            );
        }
    }
}
