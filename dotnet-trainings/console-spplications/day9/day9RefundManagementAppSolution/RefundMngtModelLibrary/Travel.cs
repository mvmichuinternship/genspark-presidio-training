using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class Travel : ExpenseType
    {
        //internal string ExpenseDesc {  get; set; }
        //internal int ReturnAmount {  get; set; }
        /// <summary>
        /// Travel class constructor
        /// </summary>
        public Travel(string type, DateTime dateOfIssue, string description, int amount, Employee empdetails) : base(type, dateOfIssue, description, amount, empdetails)
        {
            
        }
        

    }
}
