using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = GetFromAPI();

            // // Collect user values until the value is an empty string
            // while (true)
            // {
            //     // giving some space
            //     Console.WriteLine(" ");

            //     Console.Write("Enter first name (leave empty to exit): ");
            //     string firstName = Console.ReadLine();
            //     if (firstName == "")
            //     {
            //         break;
            //     }

            //     Console.Write("Enter last name: ");
            //     string lastName = Console.ReadLine();

            //     Console.Write("Enter ID: ");
            //     int id = Int32.Parse(Console.ReadLine());

            //     Console.Write("Enter photo URL: ");
            //     string photoUrl = Console.ReadLine();

            //     // Create a new Employee instance
            //     Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            //     employees.Add(currentEmployee);
            // }

            return employees;
        }

        // ===================================================================

        public static List<Employee> GetFromAPI()
        {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient())
            {
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                // Console.WriteLine(json.SelectToken("results"));
                Console.WriteLine(json.SelectToken("results[0].name.first"));
                Console.WriteLine(json.SelectToken("results[1].name.first"));
                Console.WriteLine(json.SelectToken("results[2].name.first"));
                Console.WriteLine(json.SelectToken("results[3].name.first"));

            }

            return employees;
        }
    }
}