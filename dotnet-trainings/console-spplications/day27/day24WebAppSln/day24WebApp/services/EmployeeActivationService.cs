using day24WebApp.interfaces;
using day24WebApp.models;
using day24WebApp.models.DTOs;
using day24WebApp.repositories;

namespace day24WebApp.services
{
    public class EmployeeActivationService : IUserActivationService
    {
        private readonly IRepository<int, User> _repository;
        public EmployeeActivationService(IRepository<int, User> repository) {
            _repository = repository;
        }
        public async Task<User> Activate(ActivateUserDTO activateUser)
        {
            try
            {
                var user = await _repository.Get(activateUser.UserId);
                if (activateUser.UserStatus == "Activate")
                {
                    user.Status = "Active";
                    var updateUser = await _repository.Update(user);

                }
                if (user == null)
                {
                    throw new Exception("Unable to activate user.");
                }
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to activate user");
            }
            
        }
    }
}
