using shoppingCartBLLibrary;
using shoppingCartDALLibrary;
using shoppingCartModelLibrary;
using System.Diagnostics;

namespace BLTests
{
    public class Tests
    {
        IRepository<int, Cart> repository;
        ICartService cartService;
        [SetUp]
        public void Setup()
        {
            repository = new CartRepository();
            CartItem cartItem1 = new CartItem() { CartId=301, Price=100, Quantity=3 };
            CartItem cartItem2 = new CartItem() { CartId=302, Price=1500, Quantity=2 };
            List<CartItem> cartItems = new List<CartItem>() { cartItem1, cartItem2 };
            Cart cart = new Cart() { Id=101, CustomerId=401, CartItems = cartItems };
            repository.Add(cart);
            cartService = new CartBL(repository);
        }

        [Test]
        public void Test1()
        {
            CartItem cartItem1 = new CartItem() { CartId = 301, Price = 100, Quantity = 6 };
            CartItem cartItem2 = new CartItem() { CartId = 302, Price = 1500, Quantity = 2 };
            List<CartItem> cartItems = new List<CartItem>() { cartItem1, cartItem2 };
            Cart cart = new Cart() { Id = 102, CustomerId = 402, CartItems = cartItems };
            repository.Add(cart);
            var cs = cartService.ProductQuantityInCart(cart);
            Assert.AreEqual("Cannot have more than 5 products in cart", cs);
        }
        [Test]
        public void Test2()
        {
            CartItem cartItem1 = new CartItem() { CartId = 301, Price = 100, Quantity = 6 };
            CartItem cartItem2 = new CartItem() { CartId = 302, Price = 1500, Quantity = 2 };
            List<CartItem> cartItems = new List<CartItem>() { cartItem1, cartItem2 };
            Cart cart = new Cart() { Id = 102, CustomerId = 402, CartItems = cartItems };
            repository.Add(cart);
            var cs = cartService.Discount(cart);
            Assert.AreEqual(3420.00d,cs);
        }
        
        [Test]
        public void Test3()
        {
            CartItem cartItem1 = new CartItem() { CartId = 301, Price = 30, Quantity = 1 };
            CartItem cartItem2 = new CartItem() { CartId = 302, Price = 50, Quantity = 1 };
            List<CartItem> cartItems = new List<CartItem>() { cartItem1, cartItem2 };
            Cart cart = new Cart() { Id = 102, CustomerId = 402, CartItems = cartItems };
            repository.Add(cart);
            var cs = cartService.Shipping(cart);
            Assert.AreEqual(180.00d,cs);
        }
    }
}