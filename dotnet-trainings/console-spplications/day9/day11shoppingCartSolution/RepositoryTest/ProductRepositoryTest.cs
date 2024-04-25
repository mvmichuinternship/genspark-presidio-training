using shoppingCartDALLibrary;
using shoppingCartModelLibrary;

namespace RepositoryTest
{
    public class Tests
    {
        IRepository<int, Product> repository;
        [SetUp]
        public void Setup()
        {
            repository = new ProductRepository();
            Product product = new Product() { Id =121, Name="Apple", Price=100, Image="https:/apple.com", QuantityInHand=10 };
            var result = repository.Add(product);
        }

        [Test]
        public void AddTest()
        {
            Product product = new Product() {Id=120, Name = "Apple", Price = 100, Image = "https:/apple.com", QuantityInHand = 10 };
            var result = repository.Add(product);
            Assert.AreEqual(120,result.Id);
        }

        [Test]
        public void DelTest()
        {
            Product product = new Product() { Id = 120, Name = "Apple", Price = 100, Image = "https:/apple.com", QuantityInHand = 10 };
            var rep= repository.Add(product);
            var result = repository.Delete(rep.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            Product product = new Product() { Id = 121, Name = "Banana", Price = 100, Image = "https:/apple.com", QuantityInHand = 10 };
            var result = repository.Update(product);
            Assert.AreEqual("Banana",result.Name);
        }

        [Test]
        public void GetTest()
        {
            Product product = new Product() { Id = 123, Name = "Orange", Price = 100, Image = "https:/apple.com", QuantityInHand = 10 };
            var rep = repository.Add(product);
            var result = repository.GetByKey(rep.Id);
            Assert.AreEqual("Orange", result.Name);
        }
    }
}