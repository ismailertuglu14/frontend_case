using AutoMapper;
using Shop.Core.DTOs.Base;
using Shop.Core.DTOs.Category;
using Shop.Entity.Entities;
using Shop.Repository.IRepository;
using Shop.Services.IServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetCategoryDto>>> GetCategories()
        {
            try
            {
                List<Category> categories = (await _categoryRepository.GetListAsync(c => !c.IsDeleted)).ToList();
                List<GetCategoryDto> categoryDTOs = _mapper.Map<List<GetCategoryDto>>(categories);
                return Response<List<GetCategoryDto>>.Success(categoryDTOs);
            }catch (Exception ex) 
            {
                Debug.WriteLine(ex);
                return Response<List<GetCategoryDto>>.Fail(StatusCodes.SERVER_ERROR, ex.Message);
            }

        }
    }
}
