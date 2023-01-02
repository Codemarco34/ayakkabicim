using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductCurrencyUnitsService:GenericService<ProductCurrencyUnits>,IProductCurrencyUnitsService
{
    private readonly IProductCurrencyUnitsRepository _productCurrencyUnitsRepository;
    private readonly IMapper _mapper;

    public ProductCurrencyUnitsService(IGenericRepository<ProductCurrencyUnits> repository, IGenericUnitOfWork unitOfWork, IProductCurrencyUnitsRepository productCurrencyUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productCurrencyUnitsRepository = productCurrencyUnitsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductCurrencyUnitsDto >>> GetApiAllCurrencyUnits()
    {
        var productCurrencyUnits = await _productCurrencyUnitsRepository.GetApiAllProductCurrencyUnitsAsync();
        var productCurrencyUnitsDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrencyUnits);
        return CustomResponseDto<List<ProductCurrencyUnitsDto>>.Succes(200, productCurrencyUnitsDtos);
    }

    public async Task<List<ProductCurrencyUnitsDto>> GetWebAllCurrencyUnits()
    {
        var productCurrencyUnits = await _productCurrencyUnitsRepository.GetWebAllProductCurrencyUnitsAsync();
        var productCurrencyUnitsDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrencyUnits);
        return productCurrencyUnitsDtos;
        
    }
    

}