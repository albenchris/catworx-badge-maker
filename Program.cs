using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
        // static void Main() // Entry Point
        {
            string greeting = "Hello";
            greeting = greeting + "World";
            Console.WriteLine("greeting: " + greeting);
            Console.WriteLine($"greeting {greeting}");
            Console.WriteLine("greeting: {0}", greeting);
        }
    }
}
