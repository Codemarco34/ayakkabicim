using Microsoft.AspNetCore.Mvc;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Core.DTOs;
using Ayakkabicim.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using Ayakkabicim.Core.Models;


namespace Ayakkabicim.WEB.Controllers
{
    public class ProductVatUnitsController : Controller
    {
                        
        private readonly IProductVatUnitsService _productVatUnitsService;
    
        private readonly IMapper _mapper;

        public ProductVatUnitsController(IProductVatUnitsService productVatUnitsService, IMapper mapper)
        {
            _productVatUnitsService = productVatUnitsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productVatUnits = await _productVatUnitsService.GetWebAllProductVatUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productVatUnits = productVatUnits;
            mymodel._categorys = await _productVatUnitsService.GetWebAllProductVatUnits();
            mymodel.activeProductVatUnitsCount = productVatUnits.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductVatUnitsCount = productVatUnits.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productVatUnits = await _productVatUnitsService.GetAllAsync();
            var productVatUnitsDto = _mapper.Map<List<ProductVatUnitsDto>>(productVatUnits.ToList());
            ViewBag.vat = new SelectList(productVatUnitsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductVatUnitsDto productVatUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productVatUnitsService.AddAsync(_mapper.Map<ProductVatUnits>(productVatUnitsDto));
                TempData.Add("Success", "Kdv Değeri başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductVatUnitsController|Save|48");
            var vat = await _productVatUnitsService.GetAllAsync();
            var VatDto = _mapper.Map<List<ProductVatUnitsDto>>(vat.ToList());
            ViewBag.vat = new SelectList(VatDto, "Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductVatUnits = await _productVatUnitsService.GetByIdAsync(Id);
            var VatUnits = await _productVatUnitsService.GetAllAsync();
            var VatUnitsDto = _mapper.Map<List<ProductVatUnitsDto>>(VatUnits.ToList());
            ViewBag.vat = new SelectList(VatUnitsDto, "Name");
            return View(_mapper.Map<ProductVatUnitsDto>(ProductVatUnits));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productVatUnits = await _productVatUnitsService.GetByIdAsync(Id);
            var Vat = await _productVatUnitsService.GetAllAsync();
            var VatDto = _mapper.Map<List<ProductVatUnitsDto>>(Vat.ToList());
            ViewBag.vat = new SelectList(VatDto, "Name");
            return View(_mapper.Map<ProductVatUnitsDto>(productVatUnits));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductVatUnitsDto productVatUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productVatUnitsService.UpdateAsync(_mapper.Map<ProductVatUnits>(productVatUnitsDto));
                TempData.Add("info", "Kdv Değeri Başarıyla Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductVatUnitsController|Update|79");

            var productVatUnits = await _productVatUnitsService.GetAllAsync();
            var productVatUnitDto = _mapper.Map<List<ProductVatUnitsDto>>(productVatUnits.ToList());
            ViewBag.vat = new SelectList(productVatUnitDto, "Name");
            return View(productVatUnitsDto);
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var productVatUnits = await _productVatUnitsService.GetByIdAsync(Id);
            await _productVatUnitsService.RemoveAsync(productVatUnits);
            TempData.Add("info", "Kdv Değeri Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
