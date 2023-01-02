using Ayakkabicim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category>builder)
        {
            builder.HasData(new Category { Id = 1, Name = "Sneakers" },
                            new Category { Id = 2, Name = "Klasik Ayakkabı" },
                            new Category { Id = 3, Name = "Günlük Ayakkabı" },
                            new Category { Id = 4, Name = "Erkek Çocuk Ayakkabı" },
                            new Category { Id = 5, Name = "Kız Çocuk Ayakkabı" },
                            new Category { Id = 6, Name = "Topuklu Ayakkabı" }
                );
        }
    }
}
