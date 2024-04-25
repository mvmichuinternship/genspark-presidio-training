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

        public override Product Delete(int key)
        {
            Product product = GetByKey(key);
            Product prod = product;
            items.ToList().Remove(product);
            return prod;
        }

        public override Product GetByKey(int key)
        {
            Product product = items.FirstOrDefault(p => p.Id == key);
            return product;
        }

        public override Product Update(Product item)
        {
            Product product= GetByKey(item.Id);
            if (product != null)
            {
                product = item;
            }
            return product;
        }
    }
}
