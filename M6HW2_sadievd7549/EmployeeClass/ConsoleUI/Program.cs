using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

/**
* 04/17/2019
* CSC 153
* Dilshod Sadiev
* Employee Class
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Employee();
            developer.Name = "Alex Johnson";
            developer.IdNumber = 1323;
            developer.Department = "IT";
            developer.Position = ".NET Developer";

            Console.WriteLine($"{developer.Name} {developer.IdNumber} {developer.Department} {developer.Position}");
            Console.ReadLine();
        }
    }
}
