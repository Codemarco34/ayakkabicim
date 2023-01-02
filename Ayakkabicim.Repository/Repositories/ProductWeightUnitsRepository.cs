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
    public class ProductWeightUnitsRepository : GenericRepository<ProductsWeightUnits>, IProductWeightUnitsRepository
    {
        public ProductWeightUnitsRepository(AppDbContext context) : base(context)
        {

        }


        public async Task<List<ProductsWeightUnits>> GetApiAllProductWeightUnitsAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }

        public async Task<List<ProductsWeightUnits>> GetWebAllProductWeightUnitsAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();

        }


    }
}
