using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            /**
             * OVERVIEW---------------------------------------------------------------
             * 
             * In this Demo we will be covering "Static Classes". These Classes will not
             * be used to create an object from but we will be able to access all the
             * methods that are stored in it. The methods that are in the "Static Class"
             * must also be static. While you can store "Classes" inside the UI project
             * we want to set-up for future expansion so we will create a "Class Library"
             * to hold all of the "Classes".
             */

            do
            {
                /**
                 * INFO #1 ---------------------------------------------------------------
                 * 
                 * The first thing wwe must do is create the "Classes Library". To do this
                 * you can right click on the "Solution" in the "Solution Explorer". Then
                 * click "Add" in the menu then "New Project". Next Select "Class Library 
                 * (.NET Framework)" and give it a meaningful name. For this Demo it will
                 * called "Class Library" and hit Ok.
                 */

                /**
                 * INFO #2 ---------------------------------------------------------------
                 * 
                 * You now have a new project in your "Solution" called "ClassLibrary". Go
                 * ahead and "Delete" the class that it created for you (Class1.cs). Let's
                 * add our own class. Right click on the "ClassLibrary" project and then,
                 * "Add > Class". Give this Class a name. For this Demo it will be called
                 * "StandardMessages". Make it a public static class.
                 * 
                 * Find INFO #3 in the "StandardMessages" class
                 */

                /**
                 * INFO #4 --------------------------------------------------------------
                 * 
                 * While we have the method in the static class set up we still can not use 
                 * it yet. To be able to access the class we MUST add the "ClassLibrary" to
                 * this project's "References". Follow the "DemoClassLibrary" document to 
                 * add the Reference.
                 */

                /**
                 * INFO #5 ----------------------------------------------------------------
                 * Now the project should have access to "StandardMessages". To access the
                 * method inside that class you MUST first use the class name followed by a
                 * "." then the method name.
                 */

                StandardMessages.DisplayMainMenu();

                /**
                 * INFO #6 ----------------------------------------------------------------
                 * 
                 * You can now put all your message into the "StandardMessages" class and
                 * leave your "Main" method clear of any "Console.WriteLine"s. Let's do one
                 * more. This program gave the user a choice so there is a possablity that
                 * they will enter in something that was not a choice. So go back to the
                 * "StandardMessage" class and create another method.
                 * 
                 * Find INFO #7 in "StandardMessages".
                 */

                /**
                 * INFO #8 ----------------------------------------------------------------
                 * First we need to get the user's input. Then add a Decision structure to
                 * determine what to do. Then make the calls to the right methods.
                 */

                //string input = Console.ReadLine(); // Example #1 - scroll to INFO #9 

                /**
                 * INFO #11 ---------------------------------------------------------------
                 * 
                 * Now that the Method has been create let's gt our input once again.
                 */

                string input = StandardMessages.GetUserInput(); // Scroll to INFO #12

                if (input == "1")
                {
                    StandardMessages.DisplayDeBuggerMessage(1);
                }
                else if (input == "2")
                {
                    StandardMessages.DisplayDeBuggerMessage(2);
                }
                else
                {
                    StandardMessages.DisplayMenuError();
                }

                /**
                 * INFO #9 ----------------------------------------------------------------
                 * 
                 * This also works with "Value-Returning" methods. Go back to example one and 
                 * comment out that line of code. Next find INFO #10 in the "StandardMessages"
                 * class
                 */

            /**
             * INFO #12 -------------------------------------------------------------------
             * 
             * Now that all the methods have been moved to the static method and there are 
             * no "Console" method calls, the "Main" method is free to only worry about it's
             * job which is controling the flow of the program. This program also takes a step
             * toward "Single Responsablity" by storing anything to do with "Console" method
             * calls into one class. So if there is a need to change or add one then we only need
             * to go to one place to do so.
             */

            } while (exit == false);
        }
    }
}
