using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCartDALLibrary
{
    public class CartRepository : AbstractRepository<int, Cart>
    {
        public override async Task<Cart> Delete(int key)
        {
            Cart cart = await GetByKey(key);
            items.Remove(cart);
            return cart;
        }

        public override async Task<Cart> GetByKey(int key)
        {
            Cart cart = items.FirstOrDefault(c => c.Id == key);
            return cart;
        }

        public override async Task<Cart> Update(Cart item)
        {
            Cart cart = await GetByKey(item.Id);
            if (cart != null)
            {
                cart = item;
            }
            return cart;
        }
    }
}
