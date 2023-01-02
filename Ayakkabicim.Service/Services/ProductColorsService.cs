using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductColorsService:GenericService<ProductColors>,IProductColorsService
{
    private readonly IProductColorsRepository _productColorsRepository;
    private readonly IMapper _mapper;

    public ProductColorsService(IGenericRepository<ProductColors> repository, IGenericUnitOfWork unitOfWork, IProductColorsRepository productColorsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productColorsRepository = productColorsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors()
    {
        var productColors = await _productColorsRepository.GetApiAllProductColorsAsync();
        var productsColorsDtos = _mapper.Map<List<ProductColorsDto>>(productColors);
        return CustomResponseDto<List<ProductColorsDto>>.Succes(200, productsColorsDtos);
    }

    public async Task<List<ProductColorsDto>> GetWebAllProductColors()
    {
        var productColors = await _productColorsRepository.GetWebAllProductColorsAsync();
        var productsColorsDtos = _mapper.Map<List<ProductColorsDto>>(productColors);
        return productsColorsDtos;
        
    }
    

}