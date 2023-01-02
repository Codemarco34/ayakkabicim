using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductColorsRepository:IGenericRepository<ProductColors> 
{
    Task<List<ProductColors>> GetApiAllProductColorsAsync();
    Task<List<ProductColors>> GetWebAllProductColorsAsync();
}