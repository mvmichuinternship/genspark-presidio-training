using shoppingCartDALLibrary;
using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest
{
    public class Tests1
    {
        IRepository<int, Cart> repository;
        [SetUp]
        public void Setup()
        {
            repository = new CartRepository();
            Cart cart = new Cart() { Id = 200, CustomerId=400 };
            var result = repository.Add(cart);
        }

        [Test]
        public void AddTest()
        {
            Cart cart = new Cart() {Id = 201, CustomerId=401 };
            var result = repository.Add(cart);
            Assert.AreEqual(201, result.Id);
        }

        [Test]
        public void DelTest()
        {
            Cart cart = new Cart() { Id = 201, CustomerId=401};
            var repo = repository.Add(cart);
            var result = repository.Delete(repo.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            Cart cart = new Cart() { Id=200, CustomerId=401 };
            var result = repository.Update(cart);
            Assert.AreEqual(401, result.CustomerId);
        }

        [Test]
        public void GetTest()
        {
            Cart cart = new Cart() {Id = 201, CustomerId = 401 };
            var rep = repository.Add(cart);
            var result = repository.GetByKey(rep.Id);
            Assert.AreEqual(401, result.CustomerId);
        }
    }
}
