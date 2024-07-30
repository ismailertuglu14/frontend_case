using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.Cart;
using Shop.Entity.Entities;

namespace Shop.Services.IServices
{
    public interface ICartService
    {
        Task<Response<Cart>> Get(int cartId);
        Task<Response<object>> AddToCart(AddToCartDto dto);
        Task<Response<object>> RemoveFromCart(RemoveFromCartDto dto);
    }
}
