using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Core.Models
{
    public class ProductFeatures : BaseEntity
    {
        public int ProductId { get; set; }
        public Products Products { get; set; }


        public int ProductColorId { get; set; }
        public ProductColors ProductColors { get; set; }


        public int ProductProjectId { get; set; }
        public ProductProjects ProductProjects { get; set; }


        public int ProductBrandsId { get; set; }
        public ProductBrands ProductBrands { get; set; }


        public int CurrencyId { get; set; }
        public ProductCurrencyUnits ProductCurrencyUnits { get; set; }


        public int MeasurementId { get; set; }
        public ProductMeasurementUnits ProductMeasurementUnits { get; set; }


        public int WeightId { get; set; }
        public ProductsWeightUnits ProductWeightUnits { get; set; }

        public int ProductVatId { get; set; }
        public ProductVatUnits ProductVatUnits { get; set; }

       
    }
}
