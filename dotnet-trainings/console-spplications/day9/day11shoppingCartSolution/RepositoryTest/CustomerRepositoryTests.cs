using shoppingCartDALLibrary;
using shoppingCartModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryTest
{
    public class Tests3
    {
        IRepository<int, Customer> repository;
        [SetUp]
        public void Setup()
        {
            repository = new CustomerRepository();
            Customer customer = new Customer() { Id=400, Age=22, Phone="1234567890" };
            var result = repository.Add(customer);
        }

        [Test]
        public void AddTest()
        {
            Customer customer = new Customer() { Id = 401, Age = 23, Phone = "1234567899" };
            var result = repository.Add(customer);
            Assert.AreEqual(401, result.Id);
        }

        [Test]
        public void DelTest()
        {
            Customer customer = new Customer() { Id =401, Age = 23, Phone = "1234567899" };
            var repo = repository.Add(customer);
            var result = repository.Delete(repo.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateTest()
        {
            Customer customer = new Customer() { Id = 400, Age = 23, Phone = "1234567899" };
            var result = repository.Update(customer);
            Assert.AreEqual(23, result.Age);
        }

        [Test]
        public void GetTest()
        {
            Customer customer = new Customer() { Id = 401, Age = 23, Phone = "1234567899" };
            var rep = repository.Add(customer);
            var result = repository.GetByKey(rep.Id);
            Assert.AreEqual(23, result.Age);
        }
    }
    }
