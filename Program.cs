/*
 * Bottles
 * Pawelski
 * 1/11/2022
 * Read the code and run the program a few times to see what it does. 
 * Once you are familiar with the program, answer the questions found 
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 99; i >= 1; i--)
            {
                Console.WriteLine(i + " bottle(s) of pop on the wall.");
                Console.WriteLine(i + " bottle(s) of pop.");
                Console.WriteLine("Take one down, pass it around.");
                Console.WriteLine((i - 1) + " bottle(s) of pop on the wall.");
                Console.WriteLine();
            }
        }
    }
}
