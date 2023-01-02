using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface ICompanyFirmaService : IGenericService<CompanyFirma>
    {
        public Task<CustomResponseDto<List<CompanyFirmaDto>>> GetApiAllCompanyFirma();
        public Task<List<CompanyFirmaDto>> GetWebAllCompanyFirma();

    }
}
