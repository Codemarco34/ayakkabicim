using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class CompanySubeService:GenericService<CompanySube>,ICompanySubeService
{
    private readonly ICompanySubeRepository _companySubeRepository;
    private readonly IMapper _mapper;

    public CompanySubeService(IGenericRepository<CompanySube> repository, IGenericUnitOfWork unitOfWork, ICompanySubeRepository companySubeRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _companySubeRepository = companySubeRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<CompanySubeDto>>> GetApiAllCompanySube()
    {
        var companySube = await _companySubeRepository.GetApiAllCompanySubeAsync();
        var companySubeDtos = _mapper.Map<List<CompanySubeDto>>(companySube);
        return CustomResponseDto<List<CompanySubeDto>>.Succes(200, companySubeDtos);
    }

    public async Task<List<CompanySubeDto>> GetWebAllCompanySube()
    {
        var companySube = await _companySubeRepository.GetWebAllCompanySubeAsync();
        var companySubeDtos = _mapper.Map<List<CompanySubeDto>>(companySube);
        return companySubeDtos;
        
    }
    

}