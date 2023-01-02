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
    public class ProductCurencyUnitsRepository : GenericRepository<ProductCurrencyUnits>, IProductCurrencyUnitsRepository
    {
        public ProductCurencyUnitsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductCurrencyUnits>> GetApiAllProductCurrencyUnitsAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }

        public async Task<List<ProductCurrencyUnits>> GetWebAllProductCurrencyUnitsAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();

        }


    }
}
