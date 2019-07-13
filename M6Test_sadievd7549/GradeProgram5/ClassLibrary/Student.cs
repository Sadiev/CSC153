using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public byte NumberGrade { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
            NumberGrade = 0;
        }

        public Student(string firstName, string lastName, byte age, byte numberGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            NumberGrade = numberGrade;
        }

        



    }
}
