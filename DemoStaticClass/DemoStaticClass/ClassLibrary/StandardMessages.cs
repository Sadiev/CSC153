using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class StandardMessages
    {
        /**
         * INFO #3 -----------------------------------------------------------
         * 
         * Each program should have a menu so it only let's create the main menu.
         * This works just like creating a method from the last module.
         */

        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. Run Program");
            Console.WriteLine("2. Exit");
            Console.WriteLine("1/2 >");

            // Find INFO #4 in the "Program.cs" file
        }

        /**
         * INFO #7 -------------------------------------------------------------
         * 
         * Since the user could make a mistake and in the future we could have another
         * menu that they could make a mistake on let's create a standard menu error
         * message. Let's also create a test message so the program can be debugged.
         * This method will be deleted after code is written to replace it.
         */

        public static void DisplayMenuError()
        {
            Console.WriteLine("Not a valid choice please try again!");
        }

        public static void DisplayDeBuggerMessage(int number)
        {
            Console.WriteLine($"This is path {number}");

            // In "Program.cs" find INFO #8.
        }

        /**
         * INFO #10 ---------------------------------------------------------------
         * 
         * Let's create a value returning method to get the users input. Yes this
         * does seem like more work but this will remove any "Console" class
         * method calls from our "Main" method.
         */
         public static string GetUserInput()
        {
            return Console.ReadLine();

            // Find INFO #11 in "Program.cs"
        }
    }
}
