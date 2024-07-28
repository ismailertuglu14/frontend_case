using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.Category;

namespace Shop.Services.IServices
{
    public interface ICategoryService
    {
        Task<Response<List<GetCategoryDto>>> GetCategories();
    }
}
