using azureProductWebApp.interfaces;
using azureProductWebApp.models;

namespace azureProductWebApp.services
{
    public class ProductService : IProductService
    {

        private readonly IRepository<int, Product> _productRepository;

        public ProductService(IRepository<int, Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Product> AddNewProduct(Product product)
        {
            var result = _productRepository.Add(product);
            return result;
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            var result = _productRepository.GetAll();
            return result;
        }
    }
}
