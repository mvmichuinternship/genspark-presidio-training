using RefundMngtDALLibrary;
using RefundMngtModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtBLLibrary
{
    public class RefundRequestBL : IRefundRequest
    {
        readonly IRepository<int, ExpenseType> _raiserequest;
        public RefundRequestBL() { 
            _raiserequest = new ExpenseRepository();
        }
        public int RaiseRequest(ExpenseType expense)
        {
            var result = _raiserequest.Add(expense);

            if (result != null)
            {
                return result.ExpenseId;
            }
            throw new Exception("Cannot add expense");
        }
    }
}
