using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5ConsoleApp
{
    internal class CowsAndBulls
    {
        public int cows = 0;
        public int bulls = 0;
        public int guess = 0;
        public string word;
        public string target="golf";

        public string GetInput()
        {

                Console.WriteLine("Enter your guess");
                string input = Console.ReadLine();
            return input;
        }
        public int GuessWord(string word)
        {
            cows = 0;
            bulls = 0;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    for (int j = 0; j < target.Length; j++)
            //    {
            //        if (word[i] == target[j])
            //        {
            //            if (i == j){
            //                cows++;
            //                break;
            //            }
            //            else
            //            {
            //                bulls++;
            //                break;
            //            }
            //        }


            //    }


            //}
            for (int i = 0; i < word.Length; i++)
            {
                if (target.Contains(word[i]))
                {
                    if (word.IndexOf(target[i]) == i)
                    {
                        cows++;
                    }
                    else
                    {
                        bulls++;
                    }
                }
                
                
            }
            Console.WriteLine("Cows - "+cows);
            Console.WriteLine("Bulls - "+bulls);

            return cows;
            
    
        }
        public void CowsBulls()
        {
            do
            {
                word=GetInput();
                guess++;
                GuessWord(word);

                if (cows == 4)
                {
                    Console.WriteLine("You win!");
                    Console.WriteLine("No of guesses:\t"+guess);
                    break;
                }

            } while (cows < 4);

        }
        static void Main(string[] args)
        {
            CowsAndBulls program = new CowsAndBulls();
            program.CowsBulls();
        }
    }

}
