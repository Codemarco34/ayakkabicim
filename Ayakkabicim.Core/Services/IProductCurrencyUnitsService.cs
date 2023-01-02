using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductCurrencyUnitsService:IGenericService<ProductCurrencyUnits>
    {
        public Task<CustomResponseDto<List<ProductCurrencyUnitsDto>>> GetApiAllCurrencyUnits();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllCurrencyUnits();

    }
}
