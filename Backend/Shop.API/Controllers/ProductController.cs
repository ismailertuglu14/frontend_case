using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Services.IServices;

namespace Shop.API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string? category) 
        {
            var result = await _service.GetProducts(category);
            if (result.StatusCode == Core.DTOs.Base.StatusCodes.SUCCESS) return Ok(result);
            else return StatusCode(500, result);
        }
    }
}
