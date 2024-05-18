using PizzaShopWebApp.models;

namespace PizzaShopWebApp.interfaces
{
    public interface ITokenService
    {
        public string GenerateToken(Customer customer);

    }
}
