using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Repository.AppDbContexts.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Repository.Repositories
{
    public class ProductProjectsRepository : GenericRepository<ProductProjects>, IProductProjectsRepository
    {
        public ProductProjectsRepository(AppDbContext context) : base(context)
        {

        }


        public async Task<List<ProductProjects>> GetApiAllProductProjectsAsync()
        {
            return await _context.ProductProjects.ToListAsync();
        }

        public async Task<List<ProductProjects>> GetWebAllProductProjectsAsync()
        {
            return await _context.ProductProjects.ToListAsync();

        }


    }
}
