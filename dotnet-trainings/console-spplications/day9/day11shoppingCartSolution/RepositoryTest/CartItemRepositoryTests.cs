using shoppingCartDALLibrary;
using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest
{
    public class Tests2
    {
        IRepository<int, CartItem> repository;
        [SetUp]
        public void Setup()
        {
            repository = new CartItemRepository();
            CartItem cartItem = new CartItem() { CartId=300, Discount=10, Price=500, ProductId=200, Quantity=2 };
            var result = repository.Add(cartItem);
        }

        [Test]
        public void AddTest()
        {
            CartItem cartItem = new CartItem() { CartId = 301, Discount = 10, Price = 500, ProductId = 200, Quantity = 2 };
            var result = repository.Add(cartItem);
            Assert.AreEqual(301, result.CartId);
        }

        [Test]
        public void DelTest()
        {
            CartItem cartItem = new CartItem() {CartId = 301, Discount = 10, Price = 500, ProductId = 200, Quantity = 2 };
            var repo = repository.Add(cartItem);
            var result = repository.Delete(repo.CartId);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            CartItem cartItem = new CartItem() {CartId = 300, Discount = 10, Price = 600, ProductId = 200, Quantity = 2 };
            var result = repository.Update(cartItem);
            Assert.AreEqual(10, result.Discount);
        }

        [Test]
        public void GetTest()
        {
            CartItem cartItem = new CartItem() {CartId = 302, Discount = 10, Price = 500, ProductId = 200, Quantity = 2 };
            var rep = repository.Add(cartItem);
            var result = repository.GetByKey(rep.CartId);
            Assert.AreEqual(10, result.Discount);
        }
    }
}
