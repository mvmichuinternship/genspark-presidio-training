using Microsoft.EntityFrameworkCore;
using PizzaShopWebApp.contexts;
using PizzaShopWebApp.interfaces;
using PizzaShopWebApp.models;

namespace PizzaShopWebApp.repositories
{
    public class PizzaRepository : IRepository<int, PizzaMenu>
    {
        private PizzaShopContext context;
        public PizzaRepository(PizzaShopContext _context) { 
            context = _context;
        }
        public async Task<PizzaMenu> Add(PizzaMenu item)
        {
            context.Add(item);
            await context.SaveChangesAsync();
            return item;

        }

        public async Task<PizzaMenu> Delete(int key)
        {
            var pizza = await Get(key);
            if (pizza != null)
            {
                context.Remove(pizza);
                await context.SaveChangesAsync();
                return pizza;
            }
            throw new Exception("No pizza with the given ID");
        }

        public async Task<PizzaMenu> Get(int key)
        {
            return (await context.Pizzas.SingleOrDefaultAsync(p => p.Id == key)) ?? throw new Exception("No pizza with the given ID");
        }

        public async Task<IEnumerable<PizzaMenu>> Get()
        {
            return (await context.Pizzas.ToListAsync());
        }

        public async Task<PizzaMenu> Update(PizzaMenu item)
        {
            var pizza = await Get(item.Id);
            if (pizza != null)
            {
                context.Update(item);
                await context.SaveChangesAsync();
                return pizza;
            }
            throw new Exception("No pizza with the given ID");
        }
    }
}
