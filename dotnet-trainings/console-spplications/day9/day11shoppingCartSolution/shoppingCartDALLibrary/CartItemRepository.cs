using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCartDALLibrary
{
    public class CartItemRepository : AbstractRepository<int, CartItem>
    {
        public override async Task<CartItem> Delete(int key)
        {
            CartItem cartItem = await GetByKey(key);
            items.Remove(cartItem);
            return cartItem;
        }

        public override async Task<CartItem> GetByKey(int key)
        {
            CartItem cartItem = items.FirstOrDefault(c => c.CartId == key);
            return cartItem;
        }

        public override async Task<CartItem> Update(CartItem item)
        {
            CartItem cartItem = await GetByKey(item.CartId);
            if (cartItem != null)
            {
                cartItem = item;
            }
            return cartItem;
        }
    }
}
