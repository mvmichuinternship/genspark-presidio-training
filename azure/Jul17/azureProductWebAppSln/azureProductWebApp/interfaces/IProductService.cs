using azureProductWebApp.models;

namespace azureProductWebApp.interfaces
{
    public interface IProductService
    {
        public Task<Product> AddNewProduct(Product product);
        public Task<IEnumerable<Product>> GetAllProducts();
    }
}
