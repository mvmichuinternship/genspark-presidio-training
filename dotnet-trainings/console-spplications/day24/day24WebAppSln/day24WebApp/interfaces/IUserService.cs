using day24WebApp.models;
using day24WebApp.models.DTOs;

namespace day24WebApp.interfaces
{
    public interface IUserService
    {
        public Task<LoginReturnDTO> Login(UserLoginDTO loginDTO);
        public Task<Employee> Register(EmployeeUserDTO employeeDTO);
    }
}
