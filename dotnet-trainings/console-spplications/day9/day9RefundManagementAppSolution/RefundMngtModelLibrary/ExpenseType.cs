using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class ExpenseType
    {
        public string ExpenseTyp { get; set; }
        /// <summary>
        /// Description of Expense
        /// </summary>
        public virtual void ExpenseDescription() { 
             Console.WriteLine("Enter Expense Description");
        }
        public DateTime ExpenseDate { get; set; }
        public int ExpenseId { get; set; }
        /// <summary>
        /// Amount to be reimbursed
        /// </summary>
        public virtual void Amount() { Console.WriteLine("Enter reimbursement amount"); }

        public void ChooseExpense()
        {
            Console.WriteLine("Choose Expense Type: ");
            Console.WriteLine("1. Travel");
            Console.WriteLine("2. Meals");
            Console.WriteLine("3. Accommodation");
            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                    case 0: Console.WriteLine("Exiting");
                    break;
                    case 1: ExpenseTyp = "Travel" ;
                    break;
                    case 2: ExpenseTyp = "Meals";
                    break;
                    case 3: ExpenseTyp = "Accomodation";
                    break;
            }
        }
    }
}
