using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface ICompanyBayiService : IGenericService<CompanyBayi>
    {
        public Task<CustomResponseDto<List<CompanyBayiDto>>> GetApiAllCompanyBayi();
        public Task<List<CompanyBayiDto>> GetWebAllCompanyBayi();

    }
}
