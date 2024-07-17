using azureProductWebApp.context;
using azureProductWebApp.repository;
using azureProductWebApp.models;
using Microsoft.EntityFrameworkCore;
using azureProductWebApp.interfaces;

namespace azureProductWebApp.repository
{
    public class ProductRepository : IRepository<int, Product>
    {
        private AzureAppContext _context;

        public ProductRepository(AzureAppContext context)
        {
            _context = context;
        }
        public async Task<Product> Add(Product item)
        {

            _context.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<Product> Delete(int key)
        {
            var product = await Get(key);
            if (product != null)
            {
                _context.Remove(product);
                await _context.SaveChangesAsync();
                return product;
            }
            throw new Exception("No product with the given ID");
        }

        public async Task<Product> Get(int key)
        {
            return (await _context.Products.SingleOrDefaultAsync(u => u.Id == key));
        }



        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Update(Product item)
        {
            var product = await Get(item.Id);
            if (product != null)
            {
                _context.Update(item);
                await _context.SaveChangesAsync();
                return product;
            }
            throw new Exception("No product with the given ID");
        }

       
    
}
}
