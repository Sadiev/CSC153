using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

/**
* 04/17/2019
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
            Pet dog = new Pet();
            dog.Name = "Rex";
            dog.Type = "Dog";
            dog.Age = 5;
            
            Console.WriteLine($"{dog.Name} {dog.Type} {dog.Age}");
            Console.ReadLine();
        }
    }
}
