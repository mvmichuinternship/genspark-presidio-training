using RefundMngtModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefundMngtBLLibrary
{
    public interface IEmployeeBL
    {
        int AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
    }
}
