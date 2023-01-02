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
    public class ProductMeasurementUnitsRepository : GenericRepository<ProductMeasurementUnits>, IProductMeasurementUnitsRepository
    {
        public ProductMeasurementUnitsRepository(AppDbContext context) : base(context)
        {

        }


        public async Task<List<ProductMeasurementUnits>> GetApiAllProductMeasurementUnitsAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();
        }

        public async Task<List<ProductMeasurementUnits>> GetWebAllProductMeasurementUnitsAsync()
        {
            return await _context.ProductMeasurementUnits.ToListAsync();

        }


    }
}
