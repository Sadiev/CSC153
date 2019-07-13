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
            string[] names = new string[5];

            int[] numArray = {1,2,3,4,5 };

            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[4]);

            

            const int SIZE = 3;

            string[] sizeArray = new string[SIZE];

            sizeArray[0] = "One";
            //sizeArray[1] = "Two";
            sizeArray[2] = "Three";

            for (int index = 0; index < sizeArray.Length; index++)
            {
                Console.WriteLine(sizeArray[index]);
            }

            const int ROWS = 3;
            const int COLS = 3;

            int[,] numb = { { 1,2,3},
                            { 4,5,6},
                            { 7,8,9} };

            numb[1,1]= 5;
            numb[2,2]= 10;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Console.WriteLine(numb[row,col]);
                }
            }

            

            Console.ReadLine();
        }
    }
}
