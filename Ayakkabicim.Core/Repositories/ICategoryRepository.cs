using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface ICategoryRepository:IGenericRepository<Category>
{
    Task<Category> GetApiCategoryIdProductsAsync(int categoryId);
    Task<Category> GetWebCategoryIdProductAsync(int categoryId);
    Task<List<Category>> GetApiAllCategoriesAsync();
    Task<List<Category>> GetWebAllCategoriesAsync();

}