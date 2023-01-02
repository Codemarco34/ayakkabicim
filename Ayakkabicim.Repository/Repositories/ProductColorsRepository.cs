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
    public class ProductColorsRepository : GenericRepository<ProductColors>, IProductColorsRepository
    {
        public ProductColorsRepository(AppDbContext context) : base(context)
        {

        }


        public async Task<List<ProductColors>> GetApiAllProductColorsAsync()
        {
            return await _context.ProductColors.ToListAsync();
        }

        public async Task<List<ProductColors>> GetWebAllProductColorsAsync()
        {
            return await _context.ProductColors.ToListAsync();

        }


    }
}
