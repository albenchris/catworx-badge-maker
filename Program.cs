using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // =================================================================
        
        


        // Entry Point
        static void Main(string[] args)
        // ALSO, THIS => static void Main()
        {
            List<Employee> employees = PeopleFetcher.GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
        }

        // ===================================================================
    }
}
