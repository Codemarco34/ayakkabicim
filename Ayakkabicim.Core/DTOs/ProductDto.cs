using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.DTOs
{
    public class ProductDto:BaseDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public decimal SalePrice { get; set; }
        public int IsActive { get; set; }
        public string LogoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }
        public string TechnicalWebUrl { get; set; }
        public string ExplanationWebUrl { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Stock { get; set; }

    }
}
