using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Ayakkabicim.Core.Models;

namespace Ayakkabicim.Repository.Configurations
{
    internal class ProductFeaturesConfiguration:IEntityTypeConfiguration<ProductFeatures>

    {
        public void Configure (EntityTypeBuilder<ProductFeatures> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(p => p.Products).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductId).IsRequired(false);
            builder.HasOne(pC => pC.ProductColors).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductColorId).IsRequired(false);
            builder.HasOne(pP => pP.ProductProjects).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductProjectId).IsRequired(false);
            builder.HasOne(pB => pB.ProductBrands).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductBrandsId).IsRequired(false);
            builder.HasOne(pC => pC.ProductCurrencyUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.CurrencyId).IsRequired(false);
            builder.HasOne(pM => pM.ProductMeasurementUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.MeasurementId).IsRequired(false);
            builder.HasOne(pV => pV.ProductVatUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.ProductVatId).IsRequired(false);
            builder.HasOne(pW => pW.ProductWeightUnits).WithMany(pF => pF.ProductFeatures).HasForeignKey(pF => pF.WeightId).IsRequired(false);

        }

    }
}
