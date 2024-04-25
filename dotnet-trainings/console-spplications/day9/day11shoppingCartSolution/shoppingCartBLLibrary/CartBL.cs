using shoppingCartDALLibrary;
using shoppingCartModelLibrary;

namespace shoppingCartBLLibrary
{
    public class CartBL : ICartService
    {
        readonly IRepository<int, Cart> _cartService;
        public CartBL(IRepository<int, Cart> cartService ) {
            _cartService = cartService;
        }
        public double Shipping(Cart cart)
        {
            double total = 0;
            Cart newCart = _cartService.GetByKey(cart.Id);
            for (int i = 0; i < newCart.CartItems.Count; i++)
            {
                total = total+ (newCart.CartItems[i].Price* newCart.CartItems[i].Quantity);
            }
            if (total < 100)
            {
                return total + 100;
            }
            return total;
        }

        public string ProductQuantityInCart(Cart cart)
        {
            Cart newCart = _cartService.GetByKey(cart.Id);
            for (int i = 0; i < newCart.CartItems.Count; i++)
            {
                if (newCart.CartItems[i].Quantity > 5)
                {
                    return "Cannot have more than 5 products in cart";
                }
            }
            return "Proceed shopping";
        }

        public double Discount(Cart cart)
        {
            double total=0;
            int quantity = 0;
            Cart newCart = _cartService.GetByKey(cart.Id);
            for (int i = 0; i < newCart.CartItems.Count; i++)
            {
                total = total + (newCart.CartItems[i].Price * newCart.CartItems[i].Quantity);
                quantity +=  newCart.CartItems[i].Quantity;
            }
            double final = 0;
            if (quantity>=3 && total>=1500 )
            {
                final = total - (5 * total / 100);
                return final;
            }
            return 0;
        }
    }
}
