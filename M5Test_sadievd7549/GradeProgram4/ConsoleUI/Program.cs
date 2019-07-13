using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryGrade;

// Dilshod Sadiev
// 04/11/2019
// Grade Program 4 

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROW = 5;
            Double[] avrArray = new Double[ROW];
            string[] names = new string[ROW];
            bool exit = false;
            List<int> gradesList = new List<int>();

            do
            {
                Grade.DisplayMenu();
                string input = Console.ReadLine();

                if (input == "1")
                    for (int ind = 0; ind < names.Length; ind++)
                    {
                        Console.Write($"Enter student number {ind + 1}: ");
                        names[ind] = Console.ReadLine();
                    }

                else if (input == "2")
                    avrArray = Grade.InputGrades(names);

                else if (input == "3")
                    Grade.DisplayAvr(names, avrArray);

                else if (input == "4")
                    exit = true;

                else
                    Console.WriteLine("Error: Please enter a valid number (1, 2 or 3)");

            } while (exit == false);
        }
    }
}
