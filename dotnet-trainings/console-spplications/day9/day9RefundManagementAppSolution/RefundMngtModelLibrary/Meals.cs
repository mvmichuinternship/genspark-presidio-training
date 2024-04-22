using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class Meals: ExpenseType
    {
        
        /// <summary>
        /// Meals class constructor
        /// </summary>
        public Meals( string type, DateTime dateOfIssue, string description, int amount, Employee empdetails) :base( type, dateOfIssue,  description, amount, empdetails)
        {
        }


    }
}
