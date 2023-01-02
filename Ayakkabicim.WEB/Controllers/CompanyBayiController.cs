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
    public class CompanyBayiController : Controller
    {
        private readonly ICompanyFirmaService _companyFirmaService;

        private readonly ICompanyBayiService _companyBayiService;
    
        private readonly IMapper _mapper;

        public CompanyBayiController(ICompanyBayiService companyBayiService, IMapper mapper, ICompanyFirmaService companyFirmaService)
        {
            _companyFirmaService = companyFirmaService;
            _companyBayiService = companyBayiService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var companyFirma = await _companyFirmaService.GetWebAllCompanyFirma();
            var companyBayi = await _companyBayiService.GetWebAllCompanyBayi();

            
            dynamic mymodel = new ExpandoObject();
            mymodel._companyBayi = companyBayi;
            mymodel._categorys = await _companyBayiService.GetWebAllCompanyBayi();
            mymodel.activeCompanyBayiCount = companyBayi.Where(t => t.IsActive == 1).Count();
            mymodel.passiveCompanyBayiCount = companyBayi.Where(t => t.IsActive== 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {

            var companyFirma = await _companyFirmaService.GetAllAsync();
            var companyFirmaDto = _mapper.Map<List<CompanyFirmaDto>>(companyFirma.ToList());
            ViewBag.firma = new SelectList(companyFirmaDto, "Id", "Name");

            var companyBayi = await _companyBayiService.GetAllAsync();
            var companyBayiDto = _mapper.Map<List<CompanyBayiDto>>(companyBayi.ToList());
            ViewBag.bayi = new SelectList(companyBayiDto, "Id", "Name");
            
            
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(CompanyBayiDto companyBayiDto)
        {
            if (ModelState.IsValid)
            {
                await _companyBayiService.AddAsync(_mapper.Map<CompanyBayi>(companyBayiDto));
                TempData.Add("Success", "Bayi başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanyBayiController|Save|48");
            var Bayi = await _companyBayiService.GetAllAsync();
            var BayiDto = _mapper.Map<List<CompanyBayiDto>>(Bayi.ToList());
            ViewBag.bayi = new SelectList(BayiDto, "Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var CompanyBayi = await _companyBayiService.GetByIdAsync(Id);
            var Bayi = await _companyBayiService.GetAllAsync();
            var BayiDto = _mapper.Map<List<CompanyBayiDto>>(Bayi.ToList());
            ViewBag.bayi = new SelectList(BayiDto, "Name");
            return View(_mapper.Map<CompanyBayiDto>(CompanyBayi));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var CompanyBayi = await _companyBayiService.GetByIdAsync(Id);
            var Bayi = await _companyBayiService.GetAllAsync();
            var BayiDto = _mapper.Map<List<CompanyBayiDto>>(Bayi.ToList());
            ViewBag.bayi = new SelectList(BayiDto, "Name");
            return View(_mapper.Map<CompanyBayiDto>(CompanyBayi));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CompanyBayiDto companyBayiDto)
        {
            if (ModelState.IsValid)
            {
                await _companyBayiService.UpdateAsync(_mapper.Map<CompanyBayi>(companyBayiDto));
                TempData.Add("info", "Bayi Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. CompanyBayiController|Save|48");
            var Bayi = await _companyBayiService.GetAllAsync();
            var BayiDto = _mapper.Map<List<CompanyBayiDto>>(Bayi.ToList());
            ViewBag.bayi = new SelectList(BayiDto, "BrandsName");
            return View();
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var Bayi = await _companyBayiService.GetByIdAsync(Id);
            await _companyBayiService.RemoveAsync(Bayi);
            TempData.Add("info", "Bayi Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
