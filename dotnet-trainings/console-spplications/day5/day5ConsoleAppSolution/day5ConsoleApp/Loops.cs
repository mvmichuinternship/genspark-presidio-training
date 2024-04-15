using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5ConsoleApp
{
    internal class Loops
    {
        void UnderstandingIfSelection()
        {
            string uName = "Mridu";
            if (uName == "Mridu")
            {
                Console.WriteLine("You are authorised to login!");
                Console.WriteLine("Have a great day!");
            }
            else if (uName == "Shreyu")
            {
                Console.WriteLine("Oh, you're shreyu");
            }
            else
            {
                Console.WriteLine("Bye");
            }
        }

        void UnderstandingSwitchStatements()
        {
            int num = 4;
            switch (num)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thursday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekends");
                    break;
            }
        }

        void UnderstandingForLoops()
        {
            int num = 5;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("The number is" + i);
            }
        }
        void UnderstandingWhileloops()
        {
            int num = 5;
            while (num > 0)
            {
                Console.WriteLine("Number is" + num);
                num--;
            }
        }

        void UnderstandingDowhileLoops()
        {
            int count = -1;
            do
            {
                Console.WriteLine("In Do while the value is  " + count);
                Console.WriteLine("Please enter the number");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count > 0);
        }

        static void Main(string[] args)
        {
            Loops program = new Loops();
            //program.UnderstandingIfSelection();
            program.UnderstandingSwitchStatements();
        }
    }
}
