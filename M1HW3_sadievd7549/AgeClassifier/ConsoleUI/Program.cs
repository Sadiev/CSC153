using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 01/18/2019
* CSC 153
* Dilshod Sadiev
* Age Classifier
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age; //declare variable

            Console.Write("Plese enter your age: ");

            if (byte.TryParse(Console.ReadLine(), out age))
               {
                if (age <= 1)
                    Console.WriteLine("You are an infant.");
                else if (age < 13)
                    Console.WriteLine("You are a child.");
                else if (age < 20)
                    Console.WriteLine("You are a teenager.");
                else
                    Console.WriteLine("You are an adult.");
               }
            else
               {
                Console.WriteLine("Error: Range of age is from 0 - 255.");
               }
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();

        }
    }
}
