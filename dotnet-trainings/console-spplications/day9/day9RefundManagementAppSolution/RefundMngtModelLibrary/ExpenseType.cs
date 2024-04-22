using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RefundMngtModelLibrary
{
    public class ExpenseType
    {
        public ExpenseType() { 
            ExpenseId = 0;
            ExpenseDate = new DateTime();
        }
        public ExpenseType( string type, DateTime dateOfIssue, string description, int amount, Employee empdetails)
        {

            EmpDetails = empdetails;
            ExpenseDate = dateOfIssue;
            ExpenseTyp = type;
            Amount = amount;
            ExpenseDesc = description;
        }
        public Employee EmpDetails { get; set; }
        public string ExpenseTyp { get; set; }
        /// <summary>
        /// Description of Expense
        /// </summary>
        
        public DateTime ExpenseDate { get; set; }
        public int ExpenseId { get; set; }
        public virtual void ExpenseDescription()
        {
            Console.WriteLine("Enter Expense Description");
        }
        /// <summary>
        /// Amount to be reimbursed
        /// </summary>
        public int Amount { get; set;  }
        public string ExpenseDesc { get; set; }


        
    }
}
