using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IGenericUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryIdProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetApiCategoryIdProductsAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryProductDto>(category);
            return CustomResponseDto<CategoryProductDto>.Succes(200, categoryDto);

        }


        public Task<List<CategoryProductDto>> GetWebCategoryIdProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDto>> GetWebAllCategoriesAsync()
        {
            var categorys = await _categoryRepository.GetWebAllCategoriesAsync();
            var categorysDtos = _mapper.Map<List<CategoryDto>>(categorys);
            return categorysDtos;
        }

       

        public Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryProductDto>> GetWebAllCategoryIdProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetProductsFeaturesColorsAsync()
        {
            throw new NotImplementedException();
        }
    }


}
