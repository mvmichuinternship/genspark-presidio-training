using PizzaShopWebApp.models;

namespace PizzaShopWebApp.interfaces
{
    public interface IPizzaService
    {
        public Task<IEnumerable<PizzaMenu>> GetMenu();
        public Task<IEnumerable<PizzaMenu>> GetMenuInStock();
    }
}
