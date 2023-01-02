using System;
using System.Collections.Generic;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Ayakkabicim.Core.Models;



namespace Ayakkabicim.Service.Mappings
{
    public class MapProfiles : Profile
    {
        public MapProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<ProductFeatures, ProductFeaturesDto>().ReverseMap();
            CreateMap<ProductColors, ProductColorsDto>().ReverseMap();
            CreateMap<ProductCurrencyUnits, ProductCurrencyUnitsDto>().ReverseMap();
            CreateMap<ProductMeasurementUnits, ProductMeasurementUnitsDto>().ReverseMap();
            CreateMap<ProductProjects, ProductProjectDto>().ReverseMap();
            CreateMap<ProductVatUnits, ProductVatUnitsDto>().ReverseMap();
            CreateMap<ProductsWeightUnits, ProductWeightUnitsDto>().ReverseMap();
            CreateMap<ProductBrands, ProductBrandsDto>().ReverseMap();
            CreateMap<Products, ProductCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryProductDto>().ReverseMap();


            CreateMap<CompanyBayi, CompanyBayiDto>().ReverseMap();
            CreateMap<CompanyFirma, CompanyFirmaDto>().ReverseMap();
            CreateMap<CompanySube, CompanySubeDto>().ReverseMap();




        }
    }
}
