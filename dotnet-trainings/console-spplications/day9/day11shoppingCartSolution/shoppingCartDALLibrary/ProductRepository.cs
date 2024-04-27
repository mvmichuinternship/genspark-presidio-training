using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCartDALLibrary
{
    public class ProductRepository: AbstractRepository<int, Product>
    {
        public ProductRepository() { }

        public override async Task<Product> Delete(int key)
        {
            Product product = await GetByKey(key);
            Product prod = product;
            items.ToList().Remove(product);
            return prod;
        }

        public override async Task<Product> GetByKey(int key)
        {
            Product product = items.FirstOrDefault(p => p.Id == key);
            return product;
        }

        public override async Task<Product> Update(Product item)
        {
            Product product= await GetByKey(item.Id);
            if (product != null)
            {
                product = item;
            }
            return product;
        }
    }
}
