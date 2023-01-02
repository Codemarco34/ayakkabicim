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
    public class CompanyFirmaController : Controller
    {
                        
        private readonly ICompanyFirmaService _companyFirmaService;
    
        private readonly IMapper _mapper;

        public CompanyFirmaController(ICompanyFirmaService companyFirmaService, IMapper mapper)
        {

            _companyFirmaService = companyFirmaService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var companyFirma = await _companyFirmaService.GetWebAllCompanyFirma();
            dynamic mymodel = new ExpandoObject();
            mymodel._companyFirma = companyFirma;
            mymodel._categorys = await _companyFirmaService.GetWebAllCompanyFirma();
            mymodel.activeCompanyFirmaCount = companyFirma.Where(t => t.IsActive == 1).Count();
            mymodel.passiveCompanyFirmaCount = companyFirma.Where(t => t.IsActive== 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var companyFirma = await _companyFirmaService.GetAllAsync();
            var companyFirmaDto = _mapper.Map<List<CompanyFirmaDto>>(companyFirma.ToList());
            ViewBag.firma = new SelectList(companyFirmaDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(CompanyFirmaDto companyFirmaDto)
        {
           

            if (ModelState.IsValid)
            {
                await _companyFirmaService.AddAsync(_mapper.Map<CompanyFirma>(companyFirmaDto));
                TempData.Add("Success", "Firma başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanyFirmaController|Save|48");
            var Firma = await _companyFirmaService.GetAllAsync();
            var FirmaDto = _mapper.Map<List<CompanyFirmaDto>>(Firma.ToList());
            ViewBag.Firma = new SelectList(FirmaDto, "Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var CompanyFirma = await _companyFirmaService.GetByIdAsync(Id);
            var Firma = await _companyFirmaService.GetAllAsync();
            var FirmaDto = _mapper.Map<List<CompanyFirmaDto>>(Firma.ToList());
            ViewBag.firma = new SelectList(FirmaDto, "Name");
            return View(_mapper.Map<CompanyFirmaDto>(CompanyFirma));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var CompanyFirma = await _companyFirmaService.GetByIdAsync(Id);
            var Firma = await _companyFirmaService.GetAllAsync();
            var FirmaDto = _mapper.Map<List<CompanyFirmaDto>>(Firma.ToList());
            ViewBag.firma = new SelectList(FirmaDto, "Name");
            return View(_mapper.Map<CompanyFirmaDto>(CompanyFirma));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanyFirmaDto companyFirmaDto)
        {
            if (ModelState.IsValid)
            {
                await _companyFirmaService.UpdateAsync(_mapper.Map<CompanyFirma>(companyFirmaDto));
                TempData.Add("info", "Firma Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanyFirmaController|Save|48");
            var Firma = await _companyFirmaService.GetAllAsync();
            var FirmaDto = _mapper.Map<List<CompanyFirmaDto>>(Firma.ToList());
            ViewBag.firma = new SelectList(FirmaDto, "Name");
            return View();
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var firma = await _companyFirmaService.GetByIdAsync(Id);
            await _companyFirmaService.RemoveAsync(firma);
            TempData.Add("info", "Firma Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
