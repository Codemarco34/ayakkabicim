using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface ICompanySubeService : IGenericService<CompanySube>
    {
        public Task<CustomResponseDto<List<CompanySubeDto>>> GetApiAllCompanySube();
        public Task<List<CompanySubeDto>> GetWebAllCompanySube();

    }
}
