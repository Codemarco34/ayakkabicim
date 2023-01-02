using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface ICompanyBayiRepository : IGenericRepository<CompanyBayi>
{
    Task<List<CompanyBayi>> GetApiAllCompanyBayiAsync();
    Task<List<CompanyBayi>> GetWebAllCompanyBayiAsync();
    
}