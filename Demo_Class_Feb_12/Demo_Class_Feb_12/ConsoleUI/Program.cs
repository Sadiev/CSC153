using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();

            //int num1 = rand.Next(50, 100);
            //double num2 = rand.NextDouble();

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);


            int count = 0;

            //while (count < 5)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            int num2 = 0;
            int num3 = 0;
            int AccumNumber = 0;

            while (num2 < 3)
            {
                Console.WriteLine($"Outer loop number {num2}");
                num3 = 0;
                while (num3 < 3)
                {
                    Console.WriteLine($"Inner loop number {num3}");
                    AccumNumber += 10;
                    num3++;
                }
                num2++;
            }

            Console.WriteLine(AccumNumber);


            Console.ReadLine();
        }
    }
}
