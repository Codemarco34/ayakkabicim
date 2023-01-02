using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductColorsService:IGenericService<ProductColors>
    {
        public Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllProductColors();


    }
}
