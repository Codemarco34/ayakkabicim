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
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Products>> GetProductsCategorys()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetApiAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetAllAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }


        public async Task<Products> GetProductsFeaturesColorsAsync(int ProductId)
        {
            return await _context.Products.Include(x => x.ProductFeatures).Where(x => x.Id == ProductId).SingleOrDefaultAsync();
        }

        public Task<List<Products>> GetProductsFeaturesColorsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
