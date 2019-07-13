using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/15/2019
* CSC 153
* Dilshod Sadiev
* Addition Tutor
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Console.WriteLine("1. Solve a problem");
                Console.WriteLine("2. Exit");
                Console.Write("Enter 1 or 2 > ");
                string input = Console.ReadLine();
                Console.WriteLine("");
                if (input == "1")
                {
                    Random rand = new Random();
                    int num1 = rand.Next(100, 500);
                    int num2 = rand.Next(100, 500);
                    int answer = 0;
                    Console.WriteLine("Enter the problem's answer.");
                    Console.Write($"{num1} + {num2} = ");
                    
                    input = Console.ReadLine();
                    Console.WriteLine("");


                    if (int.TryParse(input, out answer))
                    {
                        if (answer == (num1 + num2))
                            Console.WriteLine("The answer is correct!\n");
                        else
                            Console.WriteLine("The answer is wrong!\n");
                    }
                    else
                        Console.WriteLine("You have input wrong format of the answer.\nThe answer has to be a number.\n");
                    
                }
                else if (input == "2")
                {
                    exit = true;
                }
                                
            } while (exit == false);
        }
    }
}
