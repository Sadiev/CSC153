using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/15/2019
* CSC 153
* Dilshod Sadiev
* Tuition Increase
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tuition = 6000m;
            const byte INCREASE = 2;
            int year = 2020;

            do
            {
                tuition = tuition + (tuition * INCREASE / 100);
                Console.WriteLine("The tuition for {0} is {1:C}", year, tuition);
                year++;
            } while (year <=2024);

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
