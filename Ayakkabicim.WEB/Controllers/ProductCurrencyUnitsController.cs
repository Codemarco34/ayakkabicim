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
    public class ProductCurrencyUnitsController : Controller
    {
                        
        private readonly IProductCurrencyUnitsService _productCurrencyUnitsService;
    
        private readonly IMapper _mapper;

        public ProductCurrencyUnitsController(IProductCurrencyUnitsService productCurrencyUnitsService, IMapper mapper)
        {
            _productCurrencyUnitsService = productCurrencyUnitsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productCurrencyUnits = await _productCurrencyUnitsService.GetWebAllCurrencyUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productCurrencyUnits = productCurrencyUnits;
            mymodel._categorys = await _productCurrencyUnitsService.GetWebAllCurrencyUnits();
            mymodel.activeProductCurrencyUnitsCount = productCurrencyUnits.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductCurrencyUnitsCount = productCurrencyUnits.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productCurrencyUnits = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyUnitsDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrencyUnits.ToList());
            ViewBag.currency = new SelectList(productCurrencyUnitsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductCurrencyUnitsDto productsCurrencyUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productCurrencyUnitsService.AddAsync(_mapper.Map<ProductCurrencyUnits>(productsCurrencyUnitsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductCurrencyUnitsController|Save|48");
            var currency = await _productCurrencyUnitsService.GetAllAsync();
            var CurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(currency.ToList());
            ViewBag.currency = new SelectList(CurrencyDto, "Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductCurrencyUnits = await _productCurrencyUnitsService.GetByIdAsync(Id);
            var CurrencyUnits = await _productCurrencyUnitsService.GetAllAsync();
            var CurrencyUnitsDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(CurrencyUnits.ToList());
            ViewBag.currency = new SelectList(CurrencyUnitsDto, "Name");
            return View(_mapper.Map<ProductCurrencyUnitsDto>(ProductCurrencyUnits));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productCurrencyUnits = await _productCurrencyUnitsService.GetByIdAsync(Id);
            var Currency = await _productCurrencyUnitsService.GetAllAsync();
            var CurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(Currency.ToList());
            ViewBag.currency = new SelectList(CurrencyDto,"Name");
            return View(_mapper.Map<ProductCurrencyUnitsDto>(productCurrencyUnits));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductCurrencyUnitsDto productCurrencyUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productCurrencyUnitsService.UpdateAsync(_mapper.Map<ProductCurrencyUnits>(productCurrencyUnitsDto));
                TempData.Add("info", "Ürün Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductCurrencyUnitsController|Update|79");

            var productCurrencyUnits = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyUnitDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrencyUnits.ToList());
            ViewBag.currency = new SelectList(productCurrencyUnitDto, "Name");
            return View(productCurrencyUnitsDto);
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var productCurrencyUnits = await _productCurrencyUnitsService.GetByIdAsync(Id);
            await _productCurrencyUnitsService.RemoveAsync(productCurrencyUnits);
            TempData.Add("info", "Para Birimi Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
