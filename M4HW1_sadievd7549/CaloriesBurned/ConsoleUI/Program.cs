using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 03/18/2019
* CSC 153
* Dilshod Sadiev
* Calories Burned
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("This program display burned calories.");
            bool exit = false;

            do
            {
                Console.WriteLine("1. Enetr time");
                Console.WriteLine("2. Exit");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ushort runTime = 0;
                    ushort interval = 0;
                    Console.Write("How many minutes did you run? >");
                    while (!ushort.TryParse(Console.ReadLine(), out runTime))
                    {

                        Console.WriteLine("Please enter a valid number");

                    }

                    Console.Write("What interval time will display burned calories? >");
                    while (!ushort.TryParse(Console.ReadLine(), out interval))
                    {

                        Console.WriteLine("Please enter a valid number");

                    }

                    DisplayBurnCal(runTime, interval);

                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid choice (1 or 2)");
                }
            } while (exit == false);

         
        }

        public static void DisplayBurnCal(ushort runTime, ushort interval)
        {
            const byte BURN = 5;
            Console.WriteLine("");
            if (runTime>=25)
            for (int min = 25; min <= runTime; min = min + interval)
                Console.WriteLine("You burned {0} calories in {1} minutes", BURN * min, min);
            else
                Console.WriteLine("You burned 0 calories in {0} minutes", runTime);
            Console.WriteLine("");
        }
    }
}
