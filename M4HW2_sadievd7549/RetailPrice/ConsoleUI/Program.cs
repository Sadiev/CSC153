using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 03/18/2019
* CSC 153
* Dilshod Sadiev
* Retail Price Calculator
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wholesale = 0;
            byte percentage = 0;

            Console.WriteLine("Input an item's wholesale:");
            while (!decimal.TryParse(Console.ReadLine(), out wholesale))
                Console.WriteLine("Please enter a valid monetary value");

            Console.WriteLine("Input a markup percentage:");
            while (!byte.TryParse(Console.ReadLine(), out percentage))
                Console.WriteLine("Please enter a valid percentage (0-100)");

            
            Console.WriteLine($"Wholesale cost is {wholesale:C} and its markup percentage is {percentage} percent, then the item’s retail price is {CalculateRetail(wholesale, percentage):C}");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        private static decimal CalculateRetail(decimal wholesale, byte percentage)
        {
            return ((wholesale * percentage) / 100) + wholesale;
        }
    }
}
