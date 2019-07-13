using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * OVERVIEW-------------------------------------------------------------------------------
             * So we have gone over how to declare and use the void method which is a method that
             * will run its code and return control back to the line that called it. We are not
             * expecting any information to be returned. This does help but only so far now is
             * the time to expand our tool box with the "Value-Return" method.
             */

            /**
             * INFO #1---------------------------------------------------------------------------------
             * In the last demo we passed around the List address was passed to the diffent Methods
             * allowing them to change the value dirrectly. This is not always the smartest thing to
             * do. We can use a "Value-Returning" Method, but first let's start off simple.
             * 
             * This first thing to remember is that if we are going to use this type of method we
             * may need to have somewhere to store the information that is returned. 
             * 
             * Go to Example #1
             */

            // Example #1
            string firstName = GetFirstName(); // Go to INFO #2

            /**
             * INFO #3------------------------------------------------------------------------------
             * Let's add a WriteLine and another ReadLine to see if this really worked.
             */

            Console.WriteLine(firstName);

            

            /**
             * INFO #4------------------------------------------------------------------------------
             * Just like in the "Void" Method you can pass arguments and have Parameters in the 
             * method.
             */

            /**
             * INFO #5------------------------------------------------------------------------------
             * "Value-Return" methods MUST have a "return" on all its paths. Well what does this 
             * mean? Let's create a method call then the method and pass in two grades as arguments
             */
            string letterGrade = GetLetterGrade(100, 50); // Scroll to INFO #6

            /**
             * INFO #8------------------------------------------------------------------------------
             * Let's print the letter grade to see if this worked
             */

            Console.WriteLine(letterGrade);


            Console.ReadLine();
        }

        private static string GetLetterGrade(int grade1, int grade2)
        {
            /**
             * INFO #6------------------------------------------------------------------------------
             * To get the letter grade we must first get the average and if we are going to stick
             * with "Single Responsablity" then all we can do in here is to get the average. We
             * can however side step this for a moment and only to demo returning information
             * that comes from another method call by calling another method
             */
            int average = (grade1 + grade2) / 2;

            // call and return the letter
             
            return GetLetterGrade(average); // Go to INFO # 7
        }

        private static string GetLetterGrade(int average)
        {
            /**
             * INFO #7------------------------------------------------------------------------------
             * If you only have "if" statements then you MUST also have an extra return to test
             * this idea comment out all the else if statements and you will see that the method
             * yells at you about another return statement
             * 
             * Scroll to INFO #8
             */
            if (average >= 90)
                return "A";
            else if (average >= 80)
                return "B";
            else if (average >= 70)
                return "C";
            else if (average >= 60)
                return "D";
            else
                return "F";

            // return info;
        }

        /**
         * INFO #2----------------------------------------------------------------------------------
         * Notice in the header that the void has been replaced with "string". This means that the 
         * "return" must be a string. You can have diffirent datatypes here but if you are saving it
         * to a variable when the method is called then it must be the same datatype as the variable.
         * 
         * Also notice that I did a short cut here by directly returning the ReadLine() instead of
         * storing it to a variable first. Which ever works for you then use
         * 
         * Scroll to INFO #3
         */
        private static string GetFirstName()
        {
            Console.Write("Please give me your First Name. > ");

            return Console.ReadLine();
        }
    }
}
