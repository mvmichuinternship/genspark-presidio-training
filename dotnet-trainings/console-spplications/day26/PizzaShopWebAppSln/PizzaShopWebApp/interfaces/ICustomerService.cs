using PizzaShopWebApp.models;

namespace PizzaShopWebApp.interfaces
{
    public interface ICustomerService
    {
        public Task<Customer> GetCustomerById(int id);
        public Task<Customer> UpdateCustomerPhone(int id, string phoneNumber);
        public Task<IEnumerable<Customer>> GetCustomers();
    }
}
