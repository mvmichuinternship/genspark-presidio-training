using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ConsoleApplication
{
    internal class Vowels
    {
        private static void Main(string[] args)
        {

            LeastVowel();
        }
        static string GetInput()
        {
            string name;
            Console.WriteLine("Please enter the name");
            name = Console.ReadLine();
            return name;
        }

        static void Printoutput(int result)
        {
            Console.WriteLine("The result is" + result);
        }

        static void LeastVowel()
        {
            string sentence = GetInput();
            string[] words = sentence.Split(',');
            int counter = 0;
            int[] wordCounter= new int[] { };
            int[] vowelCounter = new int[5];
            int wordcount = words.Length;

            foreach (string word in words)
            {
                for(int c=0;c<word.Length;c++)
                {
                    if (word[c] == 'a' || word[c] == 'e' || word[c] == 'i' || word[c] == 'o' || word[c] == 'u')
                    {
                      counter++;  
                    }
                }
                wordCounter.Append(counter);

            }
            //int maximum = wordCounter.Max();
            //Printoutput(maximum);
            Printoutput(wordcount);
            
        }

    }
}
