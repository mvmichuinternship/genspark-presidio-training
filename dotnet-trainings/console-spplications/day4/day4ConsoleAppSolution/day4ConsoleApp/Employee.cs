using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ConsoleApp
{
    internal class Employee
    {
        double salary;
        public int Id { get; private set; }
        public string Name { get; set; }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return (salary - (salary * 10 / 100));
            }
        }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee Id\t:\t{Id}");
            Console.WriteLine($"Employee name\t:\t{Name}");
            Console.WriteLine($"Employee Date Of Birth\t:\t{DateOfBirth}");
            Console.WriteLine($"Employee Salary\t:\tRs.{Salary}");
            Console.WriteLine($"Employee Email\t:\t{Email}");
        }

        /// <summary>
        /// Default Construtor initialised to base values
        /// </summary>
        public Employee()
        {
            Id = 0;
            Name = string.Empty;
            Email = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Salary = 0;
        }

        /// <summary>
        /// Parametrised constructor demonstration
        /// </summary>
        public Employee(int id)
        {
            Id = id;
        }

        public Employee(int id, string name, double salary, DateTime dateOfBirth, string email) : this(id)
        {
            Name = name;
            Salary = salary;
            DateOfBirth = dateOfBirth;
            Email = email;
        }



    }
}
