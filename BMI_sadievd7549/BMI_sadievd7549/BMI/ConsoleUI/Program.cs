using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/07/2019
* CSC 153
* Dilshod Sadiev
* BMI
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double bmi;
            const double MIN = 18.5;
            const double MAX = 25.0;

            Console.Write("Plese enter your weight: ");
            string userWeight = Console.ReadLine();
            Console.Write("Plese enter your height: ");
            string userHeight = Console.ReadLine();


            if ((double.TryParse(userWeight, out weight)) && double.TryParse(userHeight, out height))
            {
                bmi = (weight * 703) / Math.Pow(height, 2);
                Console.WriteLine(string.Format("Your BMI is {0:0.00}", bmi));
                Console.WriteLine(Math.Pow(3,3));

                if (bmi < MIN)
                    Console.WriteLine("Your weight is uderweight.");
                else if (bmi > MAX)
                    Console.WriteLine("Your weight is overweight.");
                else
                    Console.WriteLine("Your weight is optimal.");
            }
            else
            {
                Console.WriteLine("Error: You have input the  wrong format of weight or height.\nPlease restart the program and try again.");
            }
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
