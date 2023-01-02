using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductWeightUnitsRepository:IGenericRepository<ProductsWeightUnits>
{
    Task<List<ProductsWeightUnits>> GetApiAllProductWeightUnitsAsync();
    Task<List<ProductsWeightUnits>> GetWebAllProductWeightUnitsAsync();
    
}