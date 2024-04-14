using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ConsoleApp
{
    internal class Average
    {
        private static void Main(string[] args)
        {
            AverageNumber();

        }
        static int GetInput()
        {
            int n1;
            Console.WriteLine("Please enter the the number");
            n1 = Convert.ToInt32(Console.ReadLine());
            return n1;
        }

        static void Printoutput(float result)
        {
            Console.WriteLine("The result is" + result);
        }

        static void AverageNumber()
        {
            int sum = 0;
            int counter = 0;
            int num1 = GetInput();
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (num1 % 7 == 0)
                {
                    sum += num1;
                    counter++;
                    num1 = GetInput();

                }
                else
                {
                    break;
                }
            }
            if (counter != 0)
            {
                float avg = sum / counter;
                Printoutput(avg);

            }
        }
    }
}
