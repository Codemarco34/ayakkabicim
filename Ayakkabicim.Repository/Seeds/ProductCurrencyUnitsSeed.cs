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
    internal class ProductCurrencyUnitsSeed:IEntityTypeConfiguration<ProductCurrencyUnits>
    {
        public void Configure(EntityTypeBuilder<ProductCurrencyUnits> builder)
        {
            builder.HasData(new ProductCurrencyUnits { Id = 1, Name = "Türk Lirası" },
                            new ProductCurrencyUnits { Id = 2, Name = "Dolar" },
                            new ProductCurrencyUnits { Id = 3, Name = "Euro" }
            );

        }
    }
}
