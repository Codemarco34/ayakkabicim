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
    public class CompanyFirmaRepository : GenericRepository<CompanyFirma>, ICompanyFirmaRepository
    {
        public CompanyFirmaRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<CompanyFirma>> GetApiAllCompanyFirmaAsync()
        {
            return await _context.CompanyFirma.ToListAsync();
        }

        public async Task<List<CompanyFirma>> GetWebAllCompanyFirmaAsync()
        {
            return await _context.CompanyFirma.ToListAsync();

        }


    }
}
