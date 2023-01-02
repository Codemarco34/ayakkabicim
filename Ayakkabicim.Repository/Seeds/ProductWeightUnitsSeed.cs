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
    internal class ProductWeightUnitsSeed:IEntityTypeConfiguration<ProductsWeightUnits>
    {
        public void Configure(EntityTypeBuilder<ProductsWeightUnits> builder)
        {
            builder.HasData(new ProductsWeightUnits { Id = 1, Name = "1,00" },
                            new ProductsWeightUnits { Id = 2, Name = "1,25" },
                            new ProductsWeightUnits { Id = 3, Name = "1,50" },
                            new ProductsWeightUnits { Id = 4, Name = "1,75" },
                            new ProductsWeightUnits { Id = 5, Name = "2,00" },
                            new ProductsWeightUnits { Id = 6, Name = "2,25" }

            );

        }
    }
}
