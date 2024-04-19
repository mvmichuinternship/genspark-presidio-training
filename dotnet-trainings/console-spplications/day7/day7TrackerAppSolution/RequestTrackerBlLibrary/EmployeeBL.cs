using RequestTrackerAppModel;
using RequestTrackerBLLibrary;
using RequestTrackerDalLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerBlLibrary
{
    internal class EmployeeBL:IEmployeeServices
    {
        readonly IRepository<int, Employee> _employeeRepository;
        public EmployeeBL()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public int AddEmployee(Employee employee)
        {
            var result = _employeeRepository.Add(employee);

            if (result != null)
            {
                return result.Id;
            }
            throw new DuplicateEmployeeNameException();
        }

        public Employee ChangeEmployeeName(string employeeOldName, string employeeNewName)
        {
            if (employeeOldName == employeeNewName)
            {
                throw new DuplicateEmployeeNameException();
            }
            Employee dept = GetEmployeeByName(employeeOldName);
            dept = _employeeRepository.Update(dept);
            if (dept != null)
            {
                return dept;
            }
            throw new NewEmployeeNotFoundException();
        }

        public Employee GetEmployeeById(int id)
        {
            var result = _employeeRepository.Get(id);

            if (result != null)
            {
                return result;
            }
            throw new EmployeeNotFoundException();
        }

        public Employee GetEmployeeByName(string employeeName)
        {
            List<Employee> deptList = new List<Employee>();
            deptList = _employeeRepository.GetAll();
            foreach (Employee employee in deptList)
            {
                if (employee.Name == employeeName)
                {
                    return employee;
                }
            }

            throw new EmployeeNotFoundException();

        }

        public string GetEmployeeRole(int id)
        {
            List<Employee> employees = new List<Employee>();
            employees = _employeeRepository.GetAll();
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    return employee.Role;
                }
            }

            throw new EmployeeHeadNotFoundException();
        }
    }
}
