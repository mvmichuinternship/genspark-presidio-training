﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCartModelLibrary
{
    public class Customer : IEquatable<Customer>
    {
        public int Id { get; set; }
        public string Phone { get; set; } = String.Empty;
        public int Age { get; set; }

        public int CompareTo(Customer? other)
        {
            if (this.Age == other.Age)
                return 0;
            else if (this.Age < other.Age)
                return -1;
            else
                return 1;
            //return this.Age.CompareTo(other.Age);
        }

        public bool Equals(Customer? other)
        {
            return this.Id.Equals(other.Id);
        }
        public override string ToString()
        {
            return Id + " " +  Age + " " + Phone;
        }
    }
}
