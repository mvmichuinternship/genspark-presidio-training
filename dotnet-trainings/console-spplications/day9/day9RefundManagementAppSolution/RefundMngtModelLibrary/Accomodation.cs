using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class Accomodation: ExpenseType
    {

        /// <summary>
        /// Accomodation class constructor
        /// </summary>
        public Accomodation(string type, DateTime dateOfIssue, string description, int amount, Employee empdetails) : base(type, dateOfIssue, description, amount, empdetails)
        {
        }


    }
}
