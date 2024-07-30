using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.DTOs.Cart;
using Shop.Services.IServices;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{cartId}")]
        public async Task<IActionResult> Get(int cartId)
        {
            var result = await _cartService.Get(cartId);
            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddToCart(AddToCartDto dto)
        {
            var result = await _cartService.AddToCart(dto);
            return Ok(result);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveFromCart(RemoveFromCartDto dto)
        {
            var result = await _cartService.RemoveFromCart(dto);
            return Ok(result);
        }
    }
}
