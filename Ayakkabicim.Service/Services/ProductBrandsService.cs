using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductBrandsService:GenericService<ProductBrands>,IProductBrandsService
{
    private readonly IProductBrandsRepository _productBrandsRepository;
    private readonly IMapper _mapper;

    public ProductBrandsService(IGenericRepository<ProductBrands> repository, IGenericUnitOfWork unitOfWork, IProductBrandsRepository productBrandsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productBrandsRepository = productBrandsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands()
    {
        var productBrands = await _productBrandsRepository.GetApiAllProductBrandsAsync();
        var productsBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
        return CustomResponseDto<List<ProductBrandsDto>>.Succes(200, productsBrandsDtos);
    }

    public async Task<List<ProductBrandsDto>> GetWebAllProductBrands()
    {
        var productBrands = await _productBrandsRepository.GetWebAllProductBrandsAsync();
        var ProductBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
        return ProductBrandsDtos;
        
    }
    

}