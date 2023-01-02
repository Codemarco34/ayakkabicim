using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductBrandsRepository:IGenericRepository<ProductBrands>
{
    Task<List<ProductBrands>> GetApiAllProductBrandsAsync();
    Task<List<ProductBrands>> GetWebAllProductBrandsAsync();

}