using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtModelLibrary
{
    public class Return
    {
        public Return() {
            Accept = false;
            Reason = string.Empty;
        }
        public ExpenseType ExpenseInfo { get; set; }
        public bool Accept {  get; set; }
        public string Reason { get; set; }
    }
}
