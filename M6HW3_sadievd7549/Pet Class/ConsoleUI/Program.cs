using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

/**
* 05/01/2019
* CSC 153
* Dilshod Sadiev
* Pet Class
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            byte age;

            Console.Write("Enter a pet name > ");
            pet.Name = Console.ReadLine();

            Console.Write("Enter the pet type > ");
            pet.Type = Console.ReadLine();

            Console.Write("Enter the pet age > ");
            while (!byte.TryParse(Console.ReadLine(), out age))
                  Console.WriteLine("Enter a valid age.");
            pet.Age = age;
            
            Console.WriteLine($"\nName: {pet.Name}\nType: {pet.Type}\nAge: {pet.Age}");
            Console.WriteLine("\nPress any key to exit ... ");
            Console.ReadKey();
        }
    }
}
