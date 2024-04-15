using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5ConsoleApp
{
    internal class ArrayProblem1
    {
        void UnderstandingArray()
        {
            int[] numbers = { 222,333,234,232,123 };
            int count=0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber, secondNumber, thirdNumber;
                thirdNumber = numbers[i] % 10;
                firstNumber = numbers[i]/100;
                secondNumber = (numbers[i]%100) / 10;
                Console.WriteLine(firstNumber);
                Console.WriteLine( secondNumber );
                Console.WriteLine(thirdNumber);

                if (firstNumber == secondNumber )
                {
                    if( secondNumber == thirdNumber)
                    {
                        count++;
                    }
                }
                    
            }
            Console.WriteLine("The number of repeating numbers is " + count);
        }


        static void Main(string[] args)
        {
            ArrayProblem1 program = new ArrayProblem1();
            program.UnderstandingArray();
        }
    
}
}
