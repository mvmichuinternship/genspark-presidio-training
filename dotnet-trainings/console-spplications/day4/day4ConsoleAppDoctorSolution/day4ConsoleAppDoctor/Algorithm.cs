using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ConsoleAppDoctor
{
    internal class Algorithm
    {
        static public void Main(string[] args)
        {
            ReverseNum();
        }

        static string GetInput() 
        {
            string num;
            do
            {
                Console.WriteLine("Enter Card Number");
                num = Console.ReadLine();
                if (num.Length > 16 || num.Length<16)
                {
                    Console.WriteLine("Card Number Should be 16 digits");
                }
            }while( num.Length>16 || num.Length<16);
            return num;
        }


        static void ReverseNum()
        {
            string input = GetInput();
            char[] chars = new char[input.Length];
            int j = 0;
            for (int i = input.Length-1; i >=0; i--)
            {
                chars[j] = input[i];
                j++;
            }
            //Console.WriteLine(input);
            //Console.WriteLine(chars);


            EvenNumber(chars);
        }

        static void EvenNumber(char[] reversed)
        {
            int[] sumArray = new int[reversed.Length];
            int digitSum;
            int sum = 0;
            for (int i = 0; i < reversed.Length; i++)
            {
                if (i%2==0)
                {
                    sumArray[i]=(Convert.ToInt32(new String(reversed[i],1)));
                }
                else if(i%2!=0) {
                    sumArray[i]=(Convert.ToInt32(new String(reversed[i], 1)))*2;
                }
                //Console.WriteLine(sumArray[i]);
            }

            for (int i = 0; i < sumArray.Length; i++)
            {
                digitSum = 0;
                if (sumArray[i]>9)
                {

                    while (sumArray[i] != 0) 
                    {
                        digitSum = digitSum + (sumArray[i] % 10);
                        sumArray[i] = sumArray[i] / 10;
                    }
                    sumArray[i] = digitSum;
                    //Console.WriteLine(sumArray[i]);
                }

            }
            
            for (int i = 0; i < sumArray.Length; i++)
            {
                sum = sum + sumArray[i];
            }
            Calculate (sum);
        }

        static void Calculate(int sum)
        {
            if (sum%10==0)
            {
                //Console.WriteLine(sum);
                Console.WriteLine("Valid");
            }
            else {
                Console.WriteLine("Invalid");
                //Console.WriteLine(sum);
            }
        }
    }
}
