using AutoMapper;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using System.Linq.Expressions;

namespace Ayakkabicim.Service.Services;

public class CompanyFirmaService:GenericService<CompanyFirma>,ICompanyFirmaService
{
    private readonly ICompanyFirmaRepository _companyFirmaRepository;
    private readonly IMapper _mapper;

    public CompanyFirmaService(IGenericRepository<CompanyFirma> repository, IGenericUnitOfWork unitOfWork, ICompanyFirmaRepository companyFirmaRepository, IMapper mapper) : base(repository, unitOfWork)
    {
        _companyFirmaRepository = companyFirmaRepository;
        _mapper = mapper;
    }



    public async Task<CustomResponseDto<List<CompanyFirmaDto>>> GetApiAllCompanyFirma()
    {
        var companyFirma = await _companyFirmaRepository.GetApiAllCompanyFirmaAsync();
        var companyFirmaDtos = _mapper.Map<List<CompanyFirmaDto>>(companyFirma);
        return CustomResponseDto<List<CompanyFirmaDto>>.Succes(200, companyFirmaDtos);
    }

    public async Task<List<CompanyFirmaDto>> GetWebAllCompanyFirma()
    {
        var companyFirma = await _companyFirmaRepository.GetWebAllCompanyFirmaAsync();
        var companyFirmaDtos = _mapper.Map<List<CompanyFirmaDto>>(companyFirma);
        return companyFirmaDtos;
        
    }
    

}