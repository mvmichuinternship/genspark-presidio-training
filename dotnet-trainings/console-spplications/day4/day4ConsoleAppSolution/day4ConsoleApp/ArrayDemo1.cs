using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ConsoleApp
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[3];

            newArray[0] = 6;
            newArray[1] = 7;
            newArray[2] = 27;

            int counter = newArray.Length-1;
            do {
                Console.WriteLine(newArray[counter]);
                counter--;
            } while (counter >= 0);
        }
        
    }
}
