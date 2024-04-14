using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3ConsoleApp
{
    internal class Login
    {
        private static void Main(string[] args)
        {
            LoginDetails();

        }
        static string GetInput()
        {
            string name;
            Console.WriteLine("Enter: ");
            name = Console.ReadLine();
            return name;
        }

        //static void Printoutput(float result)
        //{
        //    Console.WriteLine("The result is" + result);
        //}

        static void LoginDetails()
        {
            string uname;
            string password;
            for (int i = 0; i < 3; i++)
            {
                uname = GetInput();
                password = GetInput();

                if (uname != "ABC" || password != "123")
                {
                    Console.WriteLine("Please enter valid username and password");
                }
                else if (uname == "ABC" && password == "123")
                {
                    Console.WriteLine("Login Successful!");
                    break;
                }
            }
        }

    }
}
