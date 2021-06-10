using System;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) // Entry Point
        // ALSO, THIS...
        // static void Main() // Entry Point
        {
            string stringNum = "2";
            int intNum = Convert.ToInt16(stringNum);
            Console.WriteLine("stringNum: {0}, data-type: {1}", stringNum, stringNum.GetType());

            Console.WriteLine("intNum: {0}, data-type: {1}", intNum, intNum.GetType());
        }
    }
}
