using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 02/15/2019
* CSC 153
* Dilshod Sadiev
* Calories Burned
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte BURN = 5;
            
            for (int min=25; min<=45; min=min+10)
                Console.WriteLine("You burned {0} calories in {1} minutes", BURN*min, min);
            
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
