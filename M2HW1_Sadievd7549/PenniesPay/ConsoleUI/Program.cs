using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/14/2019
* CSC 153
* Dilshod Sadiev
* Pannies for pay
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            byte days;
            ulong TotalPay = 0;

            Console.Write("Enter the number of days (1 to 31) that you will work a month: ");

            if (byte.TryParse(Console.ReadLine(), out days) && days<=31)
            {
                for (int i = 1; days >= i; i++)
                {
                    if (i == 1)
                        TotalPay = 1;
                    else
                        TotalPay = TotalPay + TotalPay;
                }
                Console.WriteLine("Your total pay is {0:C}", TotalPay / 100m);
            }
            else
            {
                Console.WriteLine("Error: You have input the wrong format of the number of days. \nPlease restart the program and try again.");
            }
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
