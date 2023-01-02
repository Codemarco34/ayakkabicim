using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductFeaturesRepository:IGenericRepository<ProductFeatures>
{
    Task<List<ProductFeatures>> GetApiAllProductFeaturesAsync();
    Task<List<ProductFeatures>> GetWebAllProductFeaturesAsync();
}