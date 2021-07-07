using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method declared as "static"
        public static void PrintEmployees(List<Employee> employees)
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

        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if folder exists
            if (!Directory.Exists("data"))
            {
                // if not, create it
                Directory.CreateDirectory("data");
            }

            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0,-10}\t{1,-20}\t{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }
        }

        // ===================================================================

        public static void MakeBadges(List<Employee> employees)
        {
            // Create image
            Image newImage = Image.FromFile("badge.png");
            newImage.Save("data/employeeBadge.png");
        }
    }
}