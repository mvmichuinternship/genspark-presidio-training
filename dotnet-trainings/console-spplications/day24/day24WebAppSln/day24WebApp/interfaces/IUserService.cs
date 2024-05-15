using day24WebApp.models;
using day24WebApp.models.DTOs;

namespace day24WebApp.interfaces
{
    public interface IUserService
    {
        public Task<Employee> Login(UserLoginDTO loginDTO);
        public Task<Employee> Register(EmployeeUserDTO employeeDTO);
    }
}
