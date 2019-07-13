using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/07/2019
* CSC 153
* Dilshod Sadiev
* Software Sales
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            uint quantity;
            decimal discount;
            const int PACKAGE_COST = 99;

            Console.Write("Enter the number of packages purchased: ");

            if (uint.TryParse(Console.ReadLine(), out quantity))
            {
                if (quantity < 10)
                    Console.WriteLine("The total purchase cost is {0:C}", (quantity * PACKAGE_COST));
                else if (quantity < 20)
                {
                    discount = (quantity * PACKAGE_COST * 10) / 100;
                    Console.WriteLine("The amount of the discount is {0:C}", discount);
                    Console.WriteLine("The total purchase cost with the discount applied is {0:C}", (quantity * PACKAGE_COST-discount));
                }
                else if (quantity < 50)
                {
                    discount = (quantity * PACKAGE_COST * 20) / 100;
                    Console.WriteLine("The amount of the discount is {0:C}", discount);
                    Console.WriteLine("The total purchase cost with the discount applied is {0:C}", (quantity * PACKAGE_COST - discount));
                }
                else if (quantity < 100)
                {
                    discount = (quantity * PACKAGE_COST * 30) / 100;
                    Console.WriteLine("The amount of the discount is {0:C}", discount);
                    Console.WriteLine("The total purchase cost with the discount applied is {0:C}", (quantity * PACKAGE_COST - discount));
                }
                else
                {
                    discount = (quantity * PACKAGE_COST * 40) / 100;
                    Console.WriteLine("The amount of the discount is {0:C}", discount);
                    Console.WriteLine("The total purchase cost with the discount applied is {0:C}", (quantity * PACKAGE_COST - discount));
                }
            }
            else
            {
                Console.WriteLine("Error: You have input the wrong format of the number of packages purchased. \nPlease restart the program and try again.");
            }
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
