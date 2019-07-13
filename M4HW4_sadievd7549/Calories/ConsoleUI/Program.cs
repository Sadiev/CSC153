using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* 02/20/2019
* CSC 153
* Dilshod Sadiev
* Calories from Fat and Carbohydrates
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            uint fat = 0;
            uint carbs = 0;

            Console.WriteLine("This program calculates the number of calories that result from the fat and carbohydrates using.\n");

            Console.Write("Enter a number of fat grams >");
            while (!uint.TryParse(Console.ReadLine(), out fat))
                Console.Write("\nPlease enter a valid number >");

            Console.Write("\nEnter anumber of carbohydrate grams >");
            while (!uint.TryParse(Console.ReadLine(), out carbs))
                Console.Write("\nPlease enter a valid number >");

            Console.WriteLine("\nCalories from fat is {0}\nCalories from carbs is {1}\n", FatCalories(fat), CarbCalories(carbs));
            
            
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }

        private static uint CarbCalories(uint carbs)
        {
            return (carbs * 4);
        }

        private static uint FatCalories(uint fat)
        {
            return (fat * 9);
        }
    }
}
