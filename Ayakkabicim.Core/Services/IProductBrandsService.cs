using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductBrandsService:IGenericService<ProductBrands>
    {
        public Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands();
        public Task<List<ProductBrandsDto>> GetWebAllProductBrands();

    }
}
