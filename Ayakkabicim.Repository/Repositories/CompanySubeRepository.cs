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
    public class CompanySubeRepository : GenericRepository<CompanySube>, ICompanySubeRepository
    {
        public CompanySubeRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<CompanySube>> GetApiAllCompanySubeAsync()
        {
            return await _context.CompanySube.ToListAsync();
        }

        public async Task<List<CompanySube>> GetWebAllCompanySubeAsync()
        {
            return await _context.CompanySube.ToListAsync();

        }


    }
}
