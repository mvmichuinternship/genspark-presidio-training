using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using azureProductWebApp.interfaces;
using azureProductWebApp.models;
using azureProductWebApp.models.DTOs;

namespace azureProductWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productServices;
        private readonly IBlobService _blobServices;

        public ProductController(IProductService productServices, IBlobService blobServices)
        {
            _productServices = productServices;
            _blobServices = blobServices;
           
        }


        [HttpPost("AddProduct")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public async Task<ActionResult<Product>> Register([FromForm] ProductDTO imageFile)
        {
            Product product=new Product();

                try
                {
                if (imageFile.Image != null && imageFile.Image.Length > 0)
                {
                    string imageUrl = await _blobServices.UploadImageAsync(imageFile.Image);
                    product.Name= imageFile.Name;
                    product.Image = imageUrl; // Assuming Product has an ImageUrl property
                }
                Product result = await _productServices.AddNewProduct(product);
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { StatusCode = 400, Message = ex.Message });
                }
            
        }


        [HttpGet]

        public async Task<IEnumerable<Product>> GetProducts()
        {

            var requestRaise = await _productServices.GetAllProducts();
            return requestRaise.ToList();


        }
    }
}
