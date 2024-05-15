using PizzaShopWebApp.models;
using PizzaShopWebApp.models.DTOs;

namespace PizzaShopWebApp.interfaces
{
    public interface IUserService
    {
        public Task<Customer> Login(UserLoginDTO loginDTO);
        public Task<Customer> Register(CustomerUserDTO customerDTO);
    }
}
