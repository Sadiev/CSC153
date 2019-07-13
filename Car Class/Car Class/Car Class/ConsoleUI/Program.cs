using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Car car = new Car();

            do
            {
                StandardMessages.Menu();
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        car = Work.GetCarInfo();
                        break;
                    case "2":
                        car.Accelerate();
                        Console.WriteLine($"The {car.Year} {car.Make} is going {car.Speed} mph.");
                        break;
                    case "3":
                        car.Brake();
                        Console.WriteLine($"The {car.Year} {car.Make} is going {car.Speed} mph.");
                        break;
                    case "4":
                        exit = true;
                        break;

                }

            } while (exit == false);
        }
    }
}
