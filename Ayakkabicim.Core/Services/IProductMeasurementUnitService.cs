using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductMeasurementUnitService:IGenericService<ProductMeasurementUnits>
    {
        public Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurementUnits();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurementUnits();
    }
}
