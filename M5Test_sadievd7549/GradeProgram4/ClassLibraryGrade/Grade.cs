using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryGrade
{
    public static class Grade
    {
        public static void DisplayAvr(string[] names, double[] avrArray)
        {
            for (int ind = 0; ind < names.Length; ind++)
            {
                if (avrArray[ind] == 0)
                    if (names[ind] == "")
                        Console.WriteLine($"Please enter grades for student {names[ind]}.");
                    else
                        Console.WriteLine("Please enter a student name.");
                else
                {
                    if (avrArray[ind] < 60)
                        Console.WriteLine("{0} has grade average {1} which is an F. ", names[ind], avrArray[ind]);
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

        public static Double[] InputGrades(string[] names)
        {

            int grade = 0;
            List<int> gradesList = new List<int>();
            Double[] avrArray = new Double[names.Length];

            for (int ind = 0; ind < names.Length; ind++)
            {

                if (names[ind] == "" || names[ind] == null)
                    Console.WriteLine("Please enter a student name.");
                else
                {
                    gradesList.RemoveRange(0, gradesList.Count);

                    bool exit = false;
                    int i = 0;
                    do
                    {
                        Console.Write($"Enter grade number {i + 1} for student {names[ind]} or negative nuber to exit: ");

                        while (!int.TryParse(Console.ReadLine(), out grade))
                            Console.WriteLine("Please enter a valid number");
                        i++;
                        if (grade < 0)
                        {
                            if (gradesList.Count == 0)
                                gradesList.Add(0);

                            exit = true;
                        }

                        else
                            gradesList.Add(grade);
                    } while (!exit);


                    avrArray[ind] = gradesList.Average();
                }

            }
            return avrArray;
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Enter names");
            Console.WriteLine("2. Enter grade");
            Console.WriteLine("3. Get Average");
            Console.WriteLine("4. Exit");
        }
    }
}
