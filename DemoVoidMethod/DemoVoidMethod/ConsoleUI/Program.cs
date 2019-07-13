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
             * OVERVIEW---------------------------------------------------------------------------------
             * So far when you have been creating a program, you have put all your code into this "Main" 
             * method. This is not how the "Main" method is suppose to be used. The "Main" method
             * is only suppose to control where your program is at the time. To do this then we
             * need to Modularize the program and we use methods to do this. Methods are block of
             * code that live outside of the "Main" method. 
             * 
             * You can pass "arguments" to these methods. Arguments are variables, values or expressions
             * that are sent to the method, so that the method can use that data. There are two ways that
             * you can pass this information, by value or by reference.
             * 
             * When you pass by value, you are ONLY passing a copy of the value that is stored in the 
             * variable. If you pass by reference you are passing the address of the variable which allows
             * the method to change the value directly. 
             * 
             * The two types of methods we will be going over in this class are Void and Value-Returning.
             * 
             * The first thing to know is that we will be using the key word "static". This will allow the methods
             * to be used without creating an object of it first. Also if you are calling a method from a
             * "static" method then the called method should be static also.
             * 
             * The Second thing that you need to get to know is what is and how to use S.O.L.I.D principle.
             * This principle is used to help improve, expand, and maintain your program easily. We will
             * be covering all of this principle over the course of 153 and 253. For now we will go over
             * the "S" which stands for "Single-responsibility principle". 
             * 
             * "Single-responsibility" simple states the a method or class should only do one thing. Now
             * when we get to Classes this idea will become a little more complex.
             * 
             * The last thing to know is that for now we will be using the "public" access modifier. There
             * are other modifiers but for now just use public.
             */

            /** INFO #1----------------------------------------------------------------------------------
             * As with programs from here on out we will need to have a menu for our user to choose from. This means
             * that we will also need to have a loop to bring the user back. Since this will control if our program 
             * stays open or closes then it does belong in the "Main" method. We will also need a Sentry for this
             * loop so it also belongs in the "Main" method.
             */

            //Example 1 -- doWhile loop with Sentry
            bool exit = false;  // This will be our Sentry

            //Example 5
            List<int> ages = new List<int>();

            do  // This will bring the user back to the menu each time.
            {
                /**
                 * INFO #2----------------------------------------------------------------------------------
                 * Since we know that the "Main" method is only suppose to control the flow of our program, then we know
                 * that the Console.WriteLines should not go in here. This will be a great start for using methods. As
                 * stated in the OVERVIEW there are two types of methods which are "Void" and "Value-returning". For this
                 * Demo we will only work with "Void". 
                 * 
                 * A "Void" method when call will run all it's code and then return control to the calling method line. It
                 * does not return any kind of value. 
                 * 
                 * Methods can only be declare at class level. This means methods can not be declare inside other methods, so 
                 * let's create our first method outside the "Main"
                 * 
                 * Scroll down to INFO #3
                 */

                /**
                * INFO #4-------------------------------------------------------------------------------------------
                * Now that we have created the method we want to use then we must call that method. This is a simple
                * action to complete. All you need to do is use the method's name followed by parentheses.
                */

                // Example 3
                DisplayMainMenu();
                // create a RL() then Run program 

                /**
                 * INFO #5------------------------------------------------------------------------------------------
                 * Since we are using the "void" methods then we will need to get the users input inside the "Main"
                 * method. This will be use as an "argument" in our next method call.
                 */

                // Example 4
                string input = Console.ReadLine();

                /**
                 * INFO #6-------------------------------------------------------------------------------------------
                 * Now we need the program to decide where to go based on the users information. We will need to pass
                 * a List as a "arguments" once the program knows what to do. We will be passing this by reference
                 * because we are not using "Value-Returning" then we want the method to change the values directly
                 * to the list. Time to make the method
                 * 
                 * Scroll down to INFO #7
                 */

                /**
                 * INFO #12-------------------------------------------------------------------------------------------
                 * Now we will add a Switch Case to decide where to go and to call the proper method
                 */

                switch (input)
                {
                    case "1":
                        AskForAge(ref ages); //Once again notice the Key "ref"
                        break;
                    /**
                     * INFO #13-----------------------------------------------------------------------------------
                     * We will do one more. This will display the ages in the list
                     * 
                     * Scroll down to INFO #14
                     */

                    /**
                     * INFO #15-----------------------------------------------------------------------------------
                     * Now add the case and the method call
                     */
                    case "2":
                        DisplayAges(ref ages);
                        break;
                    default:
                        break;
                }

            } while (exit == false);
        }

        /**
         * INFO #3-------------------------------------------------------------------------------------------------------
         * The parts of a method are it's header and the method body. The method body live between { } and this is where 
         * you will put the code. The method header has several parts.
         * 
         * Syntax for header -- "Access Modifier", "Return Value", "Method Name", "("Datatype", "ParameterName")"
         * 
         * For this Demo we will use "public" for the "Access Modifier", next as stated before we will use the key word
         * "static". Next will come the "Return Value", since we do not want anything back from this method then we
         * will use "Void"
         * 
         * The method name should be a "verb"(action word) or "verb phrase"(action phrase). For this one we will use the
         * name "DisplayMainMenu". Notice that the name starts with a capital.
         * 
         * Inside the parentheses will live the "parameter". This includes the DataType and the parameterName. You can have
         * more then one parameter but they must be separated by a ",". You can also have no parameter, which will be the case
         * for this method.
         * 
         * The parameter name does NOT need to match what is being passed in. This parameter's scope is only to the method in
         * which it was created. This means nothing else can access this parameter name. Since it only lives in that method then
         * the name can be used again outside of the method.
         */

        //Example 2 -- "DisplayMainMenu" with no parameter
        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. Enter Ages.");
            Console.WriteLine("2. Display Ages.");
            Console.WriteLine("3. Get Oldest Age.");
            Console.WriteLine("4. Get Youngest Age.");
            Console.WriteLine("5. Exit");
            Console.Write("Enter 1/2/3/4/5 > ");

            // Scroll up to INFO #4
        }

        /**
         * INFO #7-------------------------------------------------------------------------------------------------------------
         * This method will be slightly different then the one above. We will be using a parameter in this method which 
         * when we "Pass By Value" would only need the DataType and a name. Remember that parameter will only live 
         * within the method. This one we will be getting by reference. To that we need the Key "Ref
         */

        // Example 6
        public static void AskForAge(ref List<int> ages) // We can give it the same name but do not have to
        {
            // Need a Sentry
            string exitAge = "-1";
            // Need to declare input so the loop sees it
            string input;
            //To hold our age
            int age;

            // Then a loop. if not then the user is stuck in a infinity loop
            do
            {
                Console.Write("Enter and Age or enter -1 to exit >");
                input = Console.ReadLine();

                /**
                 * INFO #8------------------------------------------------------------------------------------------------------
                 * So now what? Well I could go ahead and add the input to the list but that would go against 
                 * "Single-responsibility principle" because If I wanted to change the way we ask for an age the
                 * I would need to come to this method or if I wanted to change the way (say we decide to do this
                 * in dog years later) I would also need to come to this method so lets convert the info here
                 * (later you will be shown another way)
                 */

                while (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Enter a proper age!");
                }

                /**
                 * INFO #9---------------------------------------------------------------------------------------------------------
                 * Now we need to create another method to add the age to the list
                 * 
                 * Scroll down to INFO #10
                 */

                /**
                 * INFO #11-------------------------------------------------------------------------------------------------------
                 * Now well need to call the AddToAgeList method and pass our two arguments. You will notice that there is no
                 * "ref" in front of the age variable. The if statement is so a -1 will not be added.
                 */
                if (input != "-1")
                {
                    AddToAgeList(age, ref ages); // Notice there are no DataTypes and we used the Key "ref"
                }

                // Scroll up to INFO #12
            } while (input != "-1");
        }

        /**
         * INFO #10--------------------------------------------------------------------------------------------------------
         * This method is going to accept to parameters. The first one will be from the input. This will be by value which
         * means that a copy of the value in the variable passed will be saved. We will not be able to change the value in 
         * variable "age" just use a copy of its value. The next is the List again. Once again it will be by reference.
         */

        //Example 7
        public static void AddToAgeList(int age, ref List<int> ages)
        {
            ages.Add(age); //This is all there is in this method Scroll up to INFO #11
        }

        /**
         * INFO #14------------------------------------------------------------------------------------------------------
         * This method will take a referenced list and display it
         */

        public static void DisplayAges(ref List<int> ages)
        {
            foreach (int age in ages)
            {
                Console.WriteLine(age); // Simple

                // Scroll up to INFO #15
            }
        }
    }
}
