using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 01/29/2019
* CSC 153
* Dilshod Sadiev
* Demo If Switch
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            bool isAlive = false;
            //if (isAlive == true)
            //{
            //    Console.WriteLine("Your Alive!!");
            //}
            //else
            //{
            //    Console.WriteLine("Your Dead!!");
            //}

            //if (num1 < 3)
            //{
            //    Console.WriteLine("num is less then 3");
            //}
            //else if (num1 < 7)
            //{
            //    Console.WriteLine("num is greater then 2 less then 7");
            //}
            //else if (num1 < 15)
            //{
            //    Console.WriteLine("num is greater then 6 less then 15");
            //}
            //else
            //{
            //    Console.WriteLine("Not in Range");
            //}

            

            isAlive = true;
            //if (num1 > 0 && num1 <= 10)
            //{
            //    Console.WriteLine("This number is between 0 and 10");
            //}

            //if (isAlive==true && num1 > 5)
            //{
            //    Console.WriteLine("This works");
            //}

            //if (isAlive == true || num1 > 5)
            //{
            //    Console.WriteLine("Works also");
            //}

            //if (!(num1 < 10))
            //{
            //    Console.WriteLine("This will work fine");
            //}

            //if (isAlive == true)
            //{
            //    if (num1 == 10)
            //    {
            //        Console.WriteLine($"Your alive and {num1} years old!");
            //        Console.WriteLine("Change num1 to 9");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Your alive and {num1} years old!");
            //        Console.WriteLine("Change isAlive to false");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This can go on!");
            //}

            switch (num1)
            {
                case 5:
                    Console.WriteLine("The number is 5");
                    break;
                case 10:
                    Console.WriteLine("The number is 10");
                    break;
                default:
                    Console.WriteLine("Not sure");
                    break;
            }

            Console.ReadLine();

        }
    }
}
