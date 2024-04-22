using RefundMngtDALLibrary;
using RefundMngtModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtBLLibrary
{
    public class AcceptanceBL : IAcceptance
    {
        readonly IRepository<int, ExpenseType> _acceptance;
        public AcceptanceBL()
        {
            _acceptance = new ExpenseRepository();
        }

        public void Rejected(int id)
        {
            _acceptance.Delete(id);
        }
    }
}
