using Ayakkabicim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public abstract class BaseCompanyDto
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public int SubeId { get; set; }
        public int BayiId { get; set; }
        public int IsActive { get; set; }
        public string Explanation { get; set; }



    }
}
