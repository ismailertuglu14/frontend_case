using Microsoft.EntityFrameworkCore;
using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.Cart;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;
using System.Linq;
namespace Shop.Services.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICartItemRepository _itemRepository;
        public CartService(ICartRepository cartRepository, IProductRepository productRepository, ICartItemRepository itemRepository)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _itemRepository = itemRepository;
        }
        private int UserId = 1;
        public async Task<Response<Cart>> Get()
        {
            Cart cart = await _cartRepository.GetWhereAsync(c => c.User.Id == UserId && !c.IsClosed);
            return Response<Cart>.Success(cart);
        }

        public async Task<Response<object>> AddToCart(AddToCartDto dto)
        {
            try
            {
                Cart cart = await _cartRepository.GetWhereAsync(c => c.User.Id == UserId && !c.IsClosed,
                    ci => ci.Include(c => c.CartItems));
                if (cart == null)
                {
                    Cart newCart = new Cart()
                    {
                        UserId = UserId
                    };
                    cart = await _cartRepository.InsertAsync(newCart);
                    await _cartRepository.SaveChangesAsync();
                }
                Product? product = await _productRepository.GetByIdAsync(dto.ProductId);


                // If product already in cart then add quantity
                if (cart.CartItems.Where(ci => ci.ProductId == dto.ProductId) != null)
                {
                    CartItem cartItem2 = cart.CartItems.Where(ci => ci.ProductId == dto.ProductId).First();
                    cartItem2.Quantity += dto.Quantity;
                }
                else
                {
                    CartItem cartItem = new CartItem()
                    {
                        ProductId = dto.ProductId,
                        CartId = cart.Id,
                        Quantity = dto.Quantity
                    };
                    await _itemRepository.InsertAsync(cartItem);
                }

                await _itemRepository.SaveChangesAsync();
                return Response<object>.Success(null);
            }
            catch (Exception ex) 
            {
                return Response<object>.Fail(StatusCodes.SERVER_ERROR,ex.Message);
            }
        }
    }
}
