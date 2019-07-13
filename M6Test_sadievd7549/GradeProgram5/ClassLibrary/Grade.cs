using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Grade
    {
        public static void Avrg(List<Student> studentList)
        {
            int sum = 0;
            foreach (Student std in studentList)
            {
                //Console.WriteLine($"It is a {car.Year} {auto.Make}!");
                sum =sum +std.NumberGrade;


            }
            Console.WriteLine($"{sum / studentList.Count}");
            Console.ReadLine();
        }
    }
}
