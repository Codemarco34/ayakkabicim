using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductMeasurementUnitsRepository:IGenericRepository<ProductMeasurementUnits>
{
    Task<List<ProductMeasurementUnits>> GetApiAllProductMeasurementUnitsAsync();
    Task<List<ProductMeasurementUnits>> GetWebAllProductMeasurementUnitsAsync();
    
}