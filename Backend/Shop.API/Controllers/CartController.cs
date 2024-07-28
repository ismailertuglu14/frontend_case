using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs.Cart;
using Shop.Services.IServices;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _cartService.Get();
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddToCart(AddToCartDto dto)
        {
            var result = await _cartService.AddToCart(dto);
            return Ok(result);
        }
    }
}
