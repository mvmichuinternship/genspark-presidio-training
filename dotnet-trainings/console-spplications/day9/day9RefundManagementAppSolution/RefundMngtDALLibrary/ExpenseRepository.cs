using RefundMngtModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtDALLibrary
{
    public class ExpenseRepository : IRepository<int, ExpenseType>
    {
        readonly Dictionary<int, ExpenseType> _expense;
        public ExpenseRepository()
        {
            _expense = new Dictionary<int, ExpenseType>();
        }
        private int GenerateId()
        {
            if (_expense.Count == 0)
            {
                return 1;
            }
            else
            {
                return _expense.Keys.Max() + 1;
            }
        }
        public ExpenseType Add(ExpenseType item)
        {
            if (_expense.ContainsValue(item))
            {
                return null;
            }
            _expense.Add(GenerateId(), item);
            return item;
        }

        public void Delete(int key)
        {
            if (_expense.ContainsKey(key))
            {
                var expense = _expense[key];
                _expense.Remove(key);
                
            }
        }

        public ExpenseType Get(int key)
        {
            return _expense.ContainsKey(key) ? _expense[key] : null;
        }

        public List<ExpenseType> GetAll()
        {
            if (_expense.Count == 0)
                return null;
            return _expense.Values.ToList();
        }

        public ExpenseType Update(ExpenseType item)
        {
            if (_expense.ContainsKey(item.ExpenseId))
            {
                _expense[item.ExpenseId] = item;
                return item;
            }
            return null;
        }
    }
    }
