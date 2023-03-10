using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductVatUnitsService:IGenericService<ProductVatUnits>
    {
        public Task<CustomResponseDto<List<ProductVatUnitsDto>>> GetApiAllProductVatUnits();
        public Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits();

    }
}
