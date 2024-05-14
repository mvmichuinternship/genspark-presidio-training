using day24WebApp.interfaces;
using day24WebApp.models;

namespace day24WebApp.services
{
    public class EmployeeBasicService : IEmployeeService
    {
        private readonly IRepository<int, Employee> _repository;

        public EmployeeBasicService(IRepository<int, Employee> reposiroty)
        {
            _repository = reposiroty;
        }
        public async Task<Employee> GetEmployeeByPhone(string phoneNumber)
        {
            var employee = (await _repository.Get()).FirstOrDefault(e => e.Phone == phoneNumber);
            if (employee == null)
                throw new Exception();
            return employee;

        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await _repository.Get();
            if (employees.Count() == 0)
                throw new Exception();
            return employees;
        }

        public async Task<Employee> UpdateEmployeePhone(int id, string phoneNumber)
        {
            var employee = await _repository.Get(id);
            if (employee == null)
                throw new Exception();
            employee.Phone = phoneNumber;
            employee = await _repository.Update(employee);
            return employee;
        }
    }
}
