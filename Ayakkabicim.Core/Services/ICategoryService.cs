using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface ICategoryService:IGenericService<Category>
    {
        public Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryIdProductsAsync(int categoryId);
        public Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryProductsAsync();
        public Task<List<CategoryProductDto>> GetWebCategoryIdProductsAsync(int categoryId);
        public Task<List<CategoryProductDto>> GetWebAllCategoryIdProductsAsync();
        public Task<List<CategoryDto>> GetWebAllCategoriesAsync();
        public Task<List<CategoryDto>> GetProductsFeaturesColorsAsync();




    }
}
