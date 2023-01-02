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
    public class ProductVatUnitsRepository : GenericRepository<ProductVatUnits>, IProductVatUnitsRepository 
    {
        public ProductVatUnitsRepository(AppDbContext context) : base(context)
        {

        }


        public async Task<List<ProductVatUnits>> GetApiAllProductVatUnitsAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }

        public async Task<List<ProductVatUnits>> GetWebAllProductVatUnitsAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();

        }

    }
}
