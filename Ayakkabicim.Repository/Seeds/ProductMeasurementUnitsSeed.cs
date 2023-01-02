using Ayakkabicim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ayakkabicim.Repository.Seeds
{
    internal class ProductMeasurementUnitsSeed:IEntityTypeConfiguration<ProductMeasurementUnits>
    {
        public void Configure(EntityTypeBuilder<ProductMeasurementUnits> builder)
        {
            builder.HasData(new ProductMeasurementUnits { Id = 1, Name = "Numara" },
                            new ProductMeasurementUnits { Id = 2, Name = "Uzunluk/cm" }
                            
            );

        }
    }
}
