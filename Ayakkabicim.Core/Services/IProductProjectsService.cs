using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Services
{
    public interface IProductProjectsService:IGenericService<ProductProjects>
    {
        public Task<CustomResponseDto<List<ProductProjectDto>>> GetApiAllProductProjects();
        public Task<List<ProductProjectDto>> GetWebAllProductProjects();
    }
}
