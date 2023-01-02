using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProductId { get; set; }
        public int ProductColorId { get; set; }
        public int WeightId { get; set; }
        public int ProductBrandsId { get; set; }
        public int ProductProjectId { get; set; }
        public int CurrencyId { get; set; }
        public int MeasurementId { get; set; }
        public int ProductVatId { get; set; }
        public int IsActive { get; set; }
        public string Explanation { get; set; }

    }
}
