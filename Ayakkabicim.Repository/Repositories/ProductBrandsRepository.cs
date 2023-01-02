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
    public class ProductBrandsRepository : GenericRepository<ProductBrands>, IProductBrandsRepository
    {
        public ProductBrandsRepository(AppDbContext context) : base(context)
        {

        }

    
        public async Task<List<ProductBrands>> GetWebAllProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        public async Task<List<ProductBrands>> GetApiAllProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
            


        }

    }
}
