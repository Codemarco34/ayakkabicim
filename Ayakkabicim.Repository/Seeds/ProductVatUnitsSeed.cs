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
    internal class ProductVatUnitsSeed:IEntityTypeConfiguration<ProductVatUnits>
    {
        public void Configure(EntityTypeBuilder<ProductVatUnits> builder)
        {
            builder.HasData(new ProductVatUnits { Id = 1, Name = "18" }
                            
            );

        }
    }
}
