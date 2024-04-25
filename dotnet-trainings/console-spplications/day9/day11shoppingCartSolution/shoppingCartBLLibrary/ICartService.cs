using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingCartBLLibrary
{
    public interface ICartService
    {
        string ProductQuantityInCart(Cart cart);
        double Shipping(Cart cart);
        double Discount(Cart cart);
    }
}
