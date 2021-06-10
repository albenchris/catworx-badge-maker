using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
        // ALSO, THIS...
        // static void Main() // Entry Point
        {
            bool isCold = true;
            Console.WriteLine(isCold ? "drink" : "add ice"); // output: drink
            Console.WriteLine(!isCold ? "drink" : "add ice"); // output: add ice
        }
    }
}
