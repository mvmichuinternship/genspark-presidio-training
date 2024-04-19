using RequestTrackerAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBlLibrary
{
    public interface IEmployeeServices
    {

        int AddEmployee(Employee employee);
        Employee ChangeEmployeeName(string employeeOldName, string employeeNewName);
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string employeeName);
        int GetEmployeeRole(int id);
    }
}
