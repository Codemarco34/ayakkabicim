using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class ProductProjectsService:GenericService<ProductProjects>,IProductProjectsService
{
    private readonly IProductProjectsRepository _productProjectsRepository;
    private readonly IMapper _mapper;

    public ProductProjectsService(IGenericRepository<ProductProjects> repository, IGenericUnitOfWork unitOfWork, IProductProjectsRepository productProjectsRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _productProjectsRepository = productProjectsRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<ProductProjectDto >>> GetApiAllProductProjects()
    {
        var productProjects = await _productProjectsRepository.GetApiAllProductProjectsAsync();
        var productProjectsDtos = _mapper.Map<List<ProductProjectDto>>(productProjects);
        return CustomResponseDto<List<ProductProjectDto>>.Succes(200, productProjectsDtos);
    }

    public async Task<List<ProductProjectDto>> GetWebAllProductProjects()
    {
        var productProjects = await _productProjectsRepository.GetWebAllProductProjectsAsync();
        var productProjectsDtos = _mapper.Map<List<ProductProjectDto>>(productProjects);
        return productProjectsDtos;
        
    }
    

}