using Shop.Core.DTOs.Base;
using Shop.Entity.Entities;

namespace Shop.Services.IServices
{
    public interface IProductService
    {
        Task<Response<List<Product>>> GetProducts(string? category);
    }
}
