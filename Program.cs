using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
        // ALSO, THIS...
        // static void Main() // Entry Point
        {
            // How do you find the area of a square? Area = side * side
            double side = 3.14;
            double area = side * side;
            Console.WriteLine("area is a {0}", area.GetType());

            Console.WriteLine($"Area: {area}²");
        }
    }
}
