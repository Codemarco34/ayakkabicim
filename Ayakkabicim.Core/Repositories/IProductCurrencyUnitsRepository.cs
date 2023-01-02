using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductCurrencyUnitsRepository:IGenericRepository<ProductCurrencyUnits>
{
    Task<List<ProductCurrencyUnits>> GetApiAllProductCurrencyUnitsAsync();
    Task<List<ProductCurrencyUnits>> GetWebAllProductCurrencyUnitsAsync();
    
}