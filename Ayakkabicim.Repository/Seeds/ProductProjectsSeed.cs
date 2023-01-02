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
    internal class ProductProjectsSeed:IEntityTypeConfiguration<ProductProjects>
    {
        public void Configure(EntityTypeBuilder<ProductProjects> builder)
        {
            builder.HasData(new ProductProjects { Id = 1, Name = "SuperStep" },
                            new ProductProjects { Id = 2, Name = "Ayakkabı Dünyası" },
                            new ProductProjects { Id = 3, Name = "Flo" }

            );

        }
    }
}
