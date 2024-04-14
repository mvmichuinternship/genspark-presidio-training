using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ConsoleApp
{
    internal class LengthofUserName
    {
        private static void Main(string[] args)
        {
            LengthofName();

        }
        static string GetInput()
        {
            string name;
            Console.WriteLine("Please enter the name");
            name = Console.ReadLine();
            return name;
        }

        static void Printoutput(float result)
        {
            Console.WriteLine("The result is" + result);
        }

        static void LengthofName()
        {
            string name = GetInput();
            int counter = 0;
            foreach (char s in name)
            {
                if (s != ' ')
                {
                    counter++;
                }
            }
            Printoutput(counter);
        }
    }
}
