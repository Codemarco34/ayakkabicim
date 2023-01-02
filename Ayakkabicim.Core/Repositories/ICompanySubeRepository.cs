using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface ICompanySubeRepository : IGenericRepository<CompanySube>
{
    Task<List<CompanySube>> GetApiAllCompanySubeAsync();
    Task<List<CompanySube>> GetWebAllCompanySubeAsync();
    
}