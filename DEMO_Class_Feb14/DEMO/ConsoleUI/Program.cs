using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                Console.WriteLine("1. Run program");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter 1 or 2");
                string input = Console.ReadLine();

                if (input == "1")
                {

                    Console.WriteLine("This program will count from 0 to your number chice.");
                    Console.WriteLine("What number? > ");
                    input = Console.ReadLine();
                    int count = 0;

                    if (int.TryParse(input, out count))
                    {
                        for (int num = 0; num <= count; num++)
                        {
                            Console.WriteLine($"Number {num}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a number!");
                        Console.WriteLine("");
                    }
                    //while (count < 5)
                    //{
                    //    Console.WriteLine(count);
                    //    count++;
                    //}
                    //Console.WriteLine("");
                }
                else if (input == "2")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Not a choice!");
                    Console.WriteLine("");
                }

            } while (exit == false);

            
            
        }
    }
}
