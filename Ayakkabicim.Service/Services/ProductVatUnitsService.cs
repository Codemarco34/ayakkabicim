using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductVatUnitsService:GenericService<ProductVatUnits>,IProductVatUnitsService
{
    private readonly IProductVatUnitsRepository _productVatUnitsRepository;
    private readonly IMapper _mapper;

    public ProductVatUnitsService(IGenericRepository<ProductVatUnits> repository, IGenericUnitOfWork unitOfWork, IProductVatUnitsRepository productVatUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productVatUnitsRepository = productVatUnitsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductVatUnitsDto >>> GetApiAllProductVatUnits()
    {
        var productVatUnits = await _productVatUnitsRepository.GetApiAllProductVatUnitsAsync();
        var productVatUnitsDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVatUnits);
        return CustomResponseDto<List<ProductVatUnitsDto>>.Succes(200, productVatUnitsDtos);
    }

    public async Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits()
    {
        var productVatUnits = await _productVatUnitsRepository.GetWebAllProductVatUnitsAsync();
        var productVatUnitsDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVatUnits);
        return productVatUnitsDtos;
        
    }
    

}