using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void Menu()
        {
            Console.WriteLine("1. Create car.");
            Console.WriteLine("2. Accelerate and Display Speed");
            Console.WriteLine("3. Brake and Display Speed");
            Console.WriteLine("4. Exit");
            Console.Write("1/2/3/4 => ");
        }
    }
}
