using Ayakkabicim.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ayakkabicim.API.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CategoriesController : CustomBaseController
        {
            private readonly ICategoryService _categoryService;

            public CategoriesController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }

            [HttpGet("[action]/{categoryId}")]
            public async Task<IActionResult> GetCategoryIdProduct(int categoryId)
            {
                return CreateActionResult(await _categoryService.GetApiCategoryIdProductsAsync(categoryId));
            }
        }
    }




