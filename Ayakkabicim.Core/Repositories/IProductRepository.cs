using Ayakkabicim.Core.Models;
using System.Collections.Generic;

namespace Ayakkabicim.Core.Repositories;

public interface IProductRepository:IGenericRepository<Products>
{
    Task<List<Products>> GetApiAllProductsCategorysAsync();
    Task<List<Products>> GetWebAllProductsCategorysAsync();
    Task<List<Products>> GetWebAllProductsAsync();
    Task<List<Products>> GetProductsFeaturesColorsAsync();
    Task<List<Products>> GetAllAsync();
  
}