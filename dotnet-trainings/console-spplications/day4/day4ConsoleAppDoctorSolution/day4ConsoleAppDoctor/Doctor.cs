using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4ConsoleAppDoctor
{
    internal class Doctor
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Experience {  get; set; }
        public string Qualification { get; set; }
        public string Speciality { get; set; }

        public Doctor(int id) { 
            Id = id;
            Name = string.Empty;
            Age = 0;
            Experience = 0;
            Qualification = string.Empty;
            Speciality = string.Empty;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Doctor's Name\t:\t{Name}");
            Console.WriteLine($"Doctor's Age\t:\t{Age}");
            Console.WriteLine($"Doctor's Experience\t:\t{Experience}");
            Console.WriteLine($"Doctor's Qualification\t:\t{Qualification}");
            Console.WriteLine($"Doctor's Speciality\t:\t{Speciality}");

        }


    }
}
