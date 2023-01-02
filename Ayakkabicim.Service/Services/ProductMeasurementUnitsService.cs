using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductMeasurementUnitsService:GenericService<ProductMeasurementUnits>,IProductMeasurementUnitService
{
    private readonly IProductMeasurementUnitsRepository _productMeasurementUnitsRepository;
    private readonly IMapper _mapper;

    public ProductMeasurementUnitsService(IGenericRepository<ProductMeasurementUnits> repository, IGenericUnitOfWork unitOfWork, IProductMeasurementUnitsRepository productMeasurementUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productMeasurementUnitsRepository = productMeasurementUnitsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurementUnits()
    {
        var productMeasurementUnits = await _productMeasurementUnitsRepository.GetApiAllProductMeasurementUnitsAsync();
        var productMeasurementUnitsDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurementUnits);
        return CustomResponseDto<List<ProductMeasurementUnitsDto>>.Succes(200, productMeasurementUnitsDtos);
    }

    public async Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurementUnits()
    {
        var productMeasurementUnits = await _productMeasurementUnitsRepository.GetWebAllProductMeasurementUnitsAsync();
        var productMeasurementUnitsDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurementUnits);
        return productMeasurementUnitsDtos;
        
    }
    

}