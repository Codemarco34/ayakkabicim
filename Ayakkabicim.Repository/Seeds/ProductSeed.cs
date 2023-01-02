using Ayakkabicim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayakkabicim.Repository.Seeds
{
    internal class ProductSeed:IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(new Products
            { Id = 1,
              CategoryId = 1,
              Name = "Test Ürün1",
              Code = "123AS",
              Barcode = "AS123",
              TechnicalWebUrl = "AS123",
              LogoFileName = "asdasdas",
              LogoFilePath = "asdsadas",
              LogoBase64Content = "asdsadas",
              ExplanationWebUrl = "adsada",
              Explanation="asdasdsad",
              ExpirationDate = DateTime.Now,
              Stock=10,
              PurchasePrice=10,
              IsMixture = 1,
              SalePrice =15,
              CreateDate=DateTime.Now,
              UpdateDate=DateTime.Now});
             
        }
    }
}
