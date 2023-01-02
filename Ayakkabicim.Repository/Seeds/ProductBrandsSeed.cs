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
    internal class ProductBrandsSeed : IEntityTypeConfiguration<ProductBrands>
    {
        public void Configure(EntityTypeBuilder<ProductBrands> builder)
        {
            builder.HasData(new ProductBrands { Id = 1, BrandsName = "Adidas" });
            

        }
    }
}
