using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Message
    {
        public static string DisplayMenu()
        {
            Console.WriteLine("1. Enter Student");
            Console.WriteLine("2. Get Average");
            Console.WriteLine("3. Exit");
            return Console.ReadLine();
        }



        public static void DisplayError()
        {
            Console.WriteLine("Error: Please enter a valid number (1, 2 or 3)");
        }
    }

}
