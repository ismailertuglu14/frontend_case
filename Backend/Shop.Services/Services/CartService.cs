﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.Cart;
using Shop.Core.Utils;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;

namespace Shop.Services.Services
{
    public class CartService : BaseService, ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICartItemRepository _itemRepository;
        public CartService(ICartRepository cartRepository, IProductRepository productRepository,
            ICartItemRepository itemRepository, IHttpContextAccessor httpContextAccessor, 
            TokenService tokenService) : base(httpContextAccessor, tokenService)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _itemRepository = itemRepository;
        }
        public async Task<Response<Cart>> Get(int cartId)
        {
            Cart? cart = await _cartRepository.GetWhereAsync(c => c.User.Id == this.UserId && c.Id == cartId && !c.IsClosed,
                 query => query.Include(c => c.CartItems)
                           .ThenInclude(ci => ci.Product)
                );

            if (cart == null) return Response<Cart>.Fail(Core.DTOs.Base.StatusCodes.NOT_FOUND, "Cart Not Found");
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

                CartItem? existingCartItem = cart.CartItems.Where(ci => ci.ProductId == dto.ProductId).FirstOrDefault();
                // If product already in cart then add quantity
                if (existingCartItem != null)
                {
                    existingCartItem.Quantity += dto.Quantity;
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
                return Response<object>.Fail(Core.DTOs.Base.StatusCodes.SERVER_ERROR,ex.Message);
            }
        }

        public async Task<Response<object>> RemoveFromCart(RemoveFromCartDto dto)
        {
            try
            {
                Cart cart = await _cartRepository.GetWhereAsync(c => c.User.Id == UserId && !c.IsClosed,
                    ci => ci.Include(c => c.CartItems));
                CartItem cartItem = cart.CartItems.FirstOrDefault(i => i.ProductId == dto.ProductId);
                if(cartItem != null)
                {
                    if(cartItem.Quantity - dto.Quantity > 0)
                    {
                        cartItem.Quantity -= dto.Quantity;
                    }
                    else
                    {
                        cart.CartItems.Remove(cartItem);
                    }
                    await _itemRepository.SaveChangesAsync();
                }
                return Response<object>.Success(null);
            }
            catch (Exception ex)
            {
                return Response<object>.Fail(Core.DTOs.Base.StatusCodes.SERVER_ERROR, ex.Message);
            }
        }
    }
}
