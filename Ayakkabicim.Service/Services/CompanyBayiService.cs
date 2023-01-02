using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class CompanyBayiService:GenericService<CompanyBayi>,ICompanyBayiService
{
    private readonly ICompanyBayiRepository _companyBayiRepository;
    private readonly IMapper _mapper;

    public CompanyBayiService(IGenericRepository<CompanyBayi> repository, IGenericUnitOfWork unitOfWork, ICompanyBayiRepository companyBayiRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _companyBayiRepository = companyBayiRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<CompanyBayiDto>>> GetApiAllCompanyBayi()
    {
        var companyBayi = await _companyBayiRepository.GetApiAllCompanyBayiAsync();
        var companyBayiDtos = _mapper.Map<List<CompanyBayiDto>>(companyBayi);
        return CustomResponseDto<List<CompanyBayiDto>>.Succes(200, companyBayiDtos);
    }

    public async Task<List<CompanyBayiDto>> GetWebAllCompanyBayi()
    {
        var companyBayi = await _companyBayiRepository.GetWebAllCompanyBayiAsync();
        var companyBayiDtos = _mapper.Map<List<CompanyBayiDto>>(companyBayi);
        return companyBayiDtos;
        
    }
    

}