using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Repository.IRepository;
using Shop.Services.IServices;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetCategories();
            if(result.StatusCode == Core.DTOs.Base.StatusCodes.SUCCESS) return Ok(result);
            else return StatusCode(500, result);
        }
    }
}
