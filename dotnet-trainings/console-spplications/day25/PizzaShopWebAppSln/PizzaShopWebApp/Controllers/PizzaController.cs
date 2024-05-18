using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaShopWebApp.exceptions;
using PizzaShopWebApp.interfaces;
using PizzaShopWebApp.models.DTOs;
using PizzaShopWebApp.models;
using Microsoft.AspNetCore.Authorization;

namespace PizzaShopWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        [Authorize]
        [HttpGet("GetMenu")]
        [ProducesResponseType(typeof(PizzaMenu), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<Customer>> GetPizza()
        {
            try
            {
                var result = await _pizzaService.GetMenu();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(401, ex.Message));
            }
        }
        [HttpGet("GetStock")]
        [ProducesResponseType(typeof(PizzaMenu), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorModel), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PizzaMenu>> GetAvailablePizza()
        {
            try
            {
                var result = await _pizzaService.GetMenuInStock();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorModel(401, ex.Message));
            }
        }
        }
}
