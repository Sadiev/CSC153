using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

// Dilshod Sadiev
// 05/09/2019
// Grade Program 5 

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Student student = new Student();
            bool exit = false;

            do
            {

                string input = Message.DisplayMenu();

                if (input == "1")
                    Add.AddStudent(student, studentList);

                else if (input == "2")
                    Grade.Avrg(studentList);



                else if (input == "3")
                    exit = true;

                else
                    Message.DisplayError();

            } while (exit == false);


            
        }
    }
}
