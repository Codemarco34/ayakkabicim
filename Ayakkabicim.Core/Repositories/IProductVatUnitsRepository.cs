using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductVatUnitsRepository:IGenericRepository<ProductVatUnits>
{
    Task<List<ProductVatUnits>> GetApiAllProductVatUnitsAsync();
    Task<List<ProductVatUnits>> GetWebAllProductVatUnitsAsync();
}