using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Core.Repositories;

public interface ICompanyFirmaRepository : IGenericRepository<CompanyFirma>
{
    Task<List<CompanyFirma>> GetApiAllCompanyFirmaAsync();
    Task<List<CompanyFirma>> GetWebAllCompanyFirmaAsync();
    
}