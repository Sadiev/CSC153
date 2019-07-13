using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Add
    {
        public static void AddStudent(Student student, List<Student> studentList)
        {
            Console.Write("Enter the studet's first name? => ");
            student.FirstName = Console.ReadLine();

            Console.Write("Enter the studet's last name? => ");
            student.LastName = Console.ReadLine();
            const int CURVE = 5;
            
            byte output=0;
            int outputGrade=0;
            Console.Write("Enter the studet's age? => ");
            
            while (!byte.TryParse(Console.ReadLine(), out output))
                Console.WriteLine("Not a valid age!");
           
            student.Age = output;

            //Console.WriteLine(student.Age +"  "+output);
            
            Console.Write("Enter the studet's grade number? => ");
            while (!byte.TryParse(Console.ReadLine(), out output))
                Console.WriteLine("Not a valid Grade number!");
            outputGrade = output + CURVE;
            student.NumberGrade = (byte)outputGrade;

            studentList.Add(student);
           
        }


    }
}
