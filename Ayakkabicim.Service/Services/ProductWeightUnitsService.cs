using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductWeightUnitsService:GenericService<ProductsWeightUnits>,IProductWeightUnitsService
{
    private readonly IProductWeightUnitsRepository _productWeightUnitsRepository;
    private readonly IMapper _mapper;

    public ProductWeightUnitsService(IGenericRepository<ProductsWeightUnits> repository, IGenericUnitOfWork unitOfWork, IProductWeightUnitsRepository productWeightUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productWeightUnitsRepository = productWeightUnitsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductWeightUnitsDto >>> GetApiAllProductWeightUnits()
    {
        var productWeightUnits = await _productWeightUnitsRepository.GetApiAllProductWeightUnitsAsync();
        var productWeightUnitsDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeightUnits);
        return CustomResponseDto<List<ProductWeightUnitsDto>>.Succes(200, productWeightUnitsDtos);
    }

    public async Task<List<ProductWeightUnitsDto>> GetWebAllProductWeightUnits()
    {
        var productWeightUnits = await _productWeightUnitsRepository.GetWebAllProductWeightUnitsAsync();
        var productWeightUnitsDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeightUnits);
        return productWeightUnitsDtos;
        
    }
    

}