using day24WebApp.models;
using day24WebApp.models.DTOs;

namespace day24WebApp.interfaces
{
    public interface IUserActivationService
    {
        public Task<User> Activate(ActivateUserDTO activateUser);
    }
}
