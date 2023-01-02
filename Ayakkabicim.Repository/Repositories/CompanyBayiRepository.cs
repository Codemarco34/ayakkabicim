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
    public class CompanyBayiRepository : GenericRepository<CompanyBayi>, ICompanyBayiRepository
    {
        public CompanyBayiRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<CompanyBayi>> GetApiAllCompanyBayiAsync()
        {
            return await _context.CompanyBayi.ToListAsync();
        }

        public async Task<List<CompanyBayi>> GetWebAllCompanyBayiAsync()
        {
            return await _context.CompanyBayi.ToListAsync();

        }


    }
}
