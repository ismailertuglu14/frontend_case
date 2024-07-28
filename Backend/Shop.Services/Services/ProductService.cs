using Microsoft.EntityFrameworkCore;
using Shop.Core.DTOs.Base;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;

namespace Shop.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Response<List<Product>>> GetProducts(string? category)
        {
            try
            {
                List<Product> products;
                
                // List all products if category null
                if (category != null && category != "")
                {
                    products = (await _productRepository.GetListAsync(
                        p => p.Category.Path == category && !p.IsDeleted,
                        pi => pi.Include(p => p.Category)
                     )).ToList();
                }
                else
                {
                    products = (await _productRepository.GetListAsync(
                        p => !p.IsDeleted,
                        pi => pi.Include(p => p.Category)
                     )).ToList();
                }
                return Response<List<Product>>.Success(products);
            }
            catch (Exception ex) 
            {
                return Response<List<Product>>.Fail(StatusCodes.SERVER_ERROR, ex.Message);
            }
        }
    }
}
