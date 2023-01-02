using Microsoft.AspNetCore.Mvc;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using Ayakkabicim.Core.Models;
using Ayakkabicim.Service.Services;


namespace Ayakkabicim.WEB.Controllers
{
    public class CompanySubeController : Controller
    {
        private readonly ICompanyFirmaService _companyFirmaService;

        private readonly ICompanySubeService _companySubeService;
    
        private readonly IMapper _mapper;

        public CompanySubeController(ICompanySubeService companySubeService, IMapper mapper, ICompanyFirmaService companyFirmaService)
        {
            _companyFirmaService = companyFirmaService;
            _companySubeService = companySubeService;
            _mapper = mapper;
            
        }

        public async Task<IActionResult> Index()
        {
            var companyFirma = await _companyFirmaService.GetWebAllCompanyFirma();
            var companySube = await _companySubeService.GetWebAllCompanySube();

            dynamic mymodel = new ExpandoObject();
            mymodel._companySube = companySube;
            mymodel._categorys = await _companySubeService.GetWebAllCompanySube();
            mymodel.activeCompanySubeCount = companySube.Where(t => t.IsActive == 1).Count();
            mymodel.passiveCompanySubeCount = companySube.Where(t => t.IsActive== 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var companyFirma = await _companyFirmaService.GetAllAsync();
            var companyFirmaDto = _mapper.Map<List<CompanyFirmaDto>>(companyFirma.ToList());
            ViewBag.firma = new SelectList(companyFirmaDto, "Id", "Name");



            var companySube = await _companySubeService.GetAllAsync();
            var companySubeDto = _mapper.Map<List<CompanySubeDto>>(companySube.ToList());
            ViewBag.sube = new SelectList(companySubeDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(CompanySubeDto companySubeDto)
        {
            if (ModelState.IsValid)
            {
                await _companySubeService.AddAsync(_mapper.Map<CompanySube>(companySubeDto));
                TempData.Add("Success", "Sube başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanySubeController|Save|48");
            var Sube = await _companySubeService.GetAllAsync();
            var SubeDto = _mapper.Map<List<CompanySubeDto>>(Sube.ToList());
            ViewBag.Sube = new SelectList(SubeDto, "Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var CompanySube = await _companySubeService.GetByIdAsync(Id);
            var Sube = await _companySubeService.GetAllAsync();
            var SubeDto = _mapper.Map<List<CompanySubeDto>>(Sube.ToList());
            ViewBag.sube = new SelectList(SubeDto, "Name");
            return View(_mapper.Map<CompanySubeDto>(CompanySube));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var CompanySube = await _companySubeService.GetByIdAsync(Id);
            var Sube = await _companySubeService.GetAllAsync();
            var SubeDto = _mapper.Map<List<CompanySubeDto>>(Sube.ToList());
            ViewBag.sube = new SelectList(SubeDto, "Name");
            return View(_mapper.Map<CompanySubeDto>(CompanySube));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanySubeDto companySubeDto)
        {
            if (ModelState.IsValid)
            {
                await _companySubeService.UpdateAsync(_mapper.Map<CompanySube>(companySubeDto));
                TempData.Add("info", "Sube Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanySubeController|Save|48");
            var Sube = await _companySubeService.GetAllAsync();
            var SubeDto = _mapper.Map<List<CompanySubeDto>>(Sube.ToList());
            ViewBag.sube = new SelectList(SubeDto, "BrandsName");
            return View();
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var Sube = await _companySubeService.GetByIdAsync(Id);
            await _companySubeService.RemoveAsync(Sube);
            TempData.Add("info", "Sube Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
