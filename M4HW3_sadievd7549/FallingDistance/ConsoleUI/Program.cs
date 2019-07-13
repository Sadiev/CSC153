using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 03/19/2019
* CSC 153
* Dilshod Sadiev
* Falling Distance
*/
namespace ConsoleUI
{
    class Program
    {
        const double G= 9.8;
        static void Main(string[] args)
        {
            uint sec = 0;
            Console.WriteLine("This program display and determine the distance the\nobject falls in a specific time period.\n");
            Console.Write("Enter the amount of time (in seconds) that an object has fallen >");
            while (!uint.TryParse(Console.ReadLine(), out sec) || sec==0)
                Console.Write("\nPlease enter a valid number >");

            Console.WriteLine("\nDistance that the object has fallen during that time interval {0} meters\n", FallingDistance(sec));
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        private static Double FallingDistance(uint sec)
        {
            return (0.5*G*Math.Pow(sec,2));
        }
    }
}
