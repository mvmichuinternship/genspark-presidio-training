using PizzaShopWebApp.interfaces;
using PizzaShopWebApp.models;
using PizzaShopWebApp.models.DTOs;
using System.Linq;

namespace PizzaShopWebApp.services
{
    public class PizzaService: IPizzaService
    {
        private readonly IRepository<int, PizzaMenu> _pizzaMenuRepo;
        //private readonly IRepository<int, PizzaStock> _pizzaStockRepo;
        public PizzaService(IRepository<int, PizzaMenu> pizzaMenu ) 
        { 
            _pizzaMenuRepo=pizzaMenu;
            //_pizzaStockRepo=pizzaStock;
        }

        public async Task<IEnumerable<PizzaMenu>> GetMenu()
        {
            var pizza = await _pizzaMenuRepo.Get();
            return pizza;
        }

        public async Task<IEnumerable<PizzaMenu>> GetMenuInStock()
        {
            //var inStock = await _pizzaStockRepo.Get();
            var pizza = await _pizzaMenuRepo.Get();
            var available = pizza.Where(p => p.Availability == "Available");
            return (IEnumerable<PizzaMenu>)available;
        }
    }
}
