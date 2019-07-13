using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dilshod Sadiev
// 03/07/2019
// Grade Program 2

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            int grades = 0;
            //int gradesTotal = 0;
            int grade = 0;
            //Double avr = 0;
            const int ROW= 5;
            
            string[] names = new string[ROW];
            Double[] avrArray = new Double[ROW];
            List<int> gradesList = new List<int>();

            do
            {
                Console.WriteLine("1. Enter names");
                Console.WriteLine("2. Enter grade");
                Console.WriteLine("3. Get Average");
                Console.WriteLine("4. Exit");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    for (int ind = 0; ind < ROW; ind++)
                    {
                        Console.Write($"Enter student number {ind+1}: ");
                        names[ind] = Console.ReadLine();                        
                    }
                    
                }
                else if (input == "2")
                {
                    for (int ind = 0; ind < ROW; ind++)
                    {

                        if (names[ind] == "" || names[ind]==null)
                            Console.WriteLine("First enter student name.");
                        else
                        {

                        
                        Console.WriteLine($"How many grades you would like enter for student {names[ind]}?");
                        while (!int.TryParse(Console.ReadLine(), out grades))
                        {

                            Console.WriteLine("Please enter a valid number");

                        }

                        gradesList.RemoveRange(0, gradesList.Count);
                        for (int i = 1; i <= grades; i++)
                        {
                            Console.Write($"Enter grade number {i} for student {names[ind]}: ");
                            while (!int.TryParse(Console.ReadLine(), out grade))
                            {

                                Console.WriteLine("Please enter a valid number");

                            }
                            //gradesTotal = gradesTotal + grade;
                            gradesList.Add(grade);
                        }
                        //avr = gradesTotal / grades;
                        avrArray[ind] = gradesList.Sum() / gradesList.Count();
                        }
                    }
                    
                }
                else if (input == "3")
                {
                    for (int ind = 0; ind < ROW; ind++)
                    {
                        if (avrArray[ind] == 0)
                            Console.WriteLine("First enter grades.");
                        else
                        {
                            if (avrArray[ind] < 60)
                                Console.WriteLine("{0} has grade average {1} which is an F. ",names[ind], avrArray[ind]);
                            else if (avrArray[ind] < 70)
                                Console.WriteLine("{0} has grade average is {1} which is an D. ", names[ind], avrArray[ind]);
                            else if (avrArray[ind] < 80)
                                Console.WriteLine("{0} has grade average is {1} which is an C. ", names[ind], avrArray[ind]);
                            else if (avrArray[ind] < 90)
                                Console.WriteLine("{0} has grade average is {1} which is an B. ", names[ind], avrArray[ind]);
                            else
                                Console.WriteLine("{0} has grade average is {1} which is an A. ", names[ind], avrArray[ind]);
                        }
                    }
                        

                }
                else if (input == "4")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number (1, 2 or 3)");
                }
            } while (exit == false);
        }
    }
}
