using RefundMngtModelLibrary;
using RefundMngtDALLibrary;

namespace RefundMngtBLLibrary
{
    public class EmployeeBL : IEmployeeBL
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

        public Employee GetEmployeeById(int id)
        {
            var result = _employeeRepository.Get(id);

            if (result != null)
            {
                return result;
            }
            throw new EmployeeNotFoundException();
        }

    }
}
