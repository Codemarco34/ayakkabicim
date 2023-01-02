using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface IProductProjectsRepository:IGenericRepository<ProductProjects>
{
    Task<List<ProductProjects>> GetApiAllProductProjectsAsync();
    Task<List<ProductProjects>> GetWebAllProductProjectsAsync();
    
}