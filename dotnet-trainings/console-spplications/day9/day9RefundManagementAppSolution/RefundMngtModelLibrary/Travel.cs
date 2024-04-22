using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class Travel : ExpenseType
    {
        internal string ExpenseDesc {  get; set; }
        internal int ReturnAmount {  get; set; }
        /// <summary>
        /// Travel class constructor
        /// </summary>
        public Travel() {
            ExpenseTyp = "Travel";
            ExpenseDesc =string.Empty;
            ReturnAmount = 0;
        }
        
        public override void ExpenseDescription() {
            ExpenseDesc = Console.ReadLine();
        }

        public override void Amount() { 
            ReturnAmount = int.Parse(Console.ReadLine());
        }
    }
}
