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
    public class ProductWeightUnitsController : Controller
    {
                        
        private readonly IProductWeightUnitsService _productWeightUnitsService;
    
        private readonly IMapper _mapper;

        public ProductWeightUnitsController(IProductWeightUnitsService productWeightUnitsService, IMapper mapper)
        {
            _productWeightUnitsService = productWeightUnitsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productWeightUnits = await _productWeightUnitsService.GetWebAllProductWeightUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productWeightUnits = productWeightUnits;
            mymodel._categorys = await _productWeightUnitsService.GetWebAllProductWeightUnits();
            mymodel.activeProductWeightUnitsCount = productWeightUnits.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductWeightUnitsCount = productWeightUnits.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productWeightUnits = await _productWeightUnitsService.GetAllAsync();
            var productWeightUnitsDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeightUnits.ToList());
            ViewBag.weight = new SelectList(productWeightUnitsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductWeightUnitsDto productWeightUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productWeightUnitsService.AddAsync(_mapper.Map<ProductsWeightUnits>(productWeightUnitsDto));
                TempData.Add("Success", "Ağırlık Birimi başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductWeightUnitsController|Save|48");
            var weight = await _productWeightUnitsService.GetAllAsync();
            var WeightDto = _mapper.Map<List<ProductWeightUnitsDto>>(weight.ToList());
            ViewBag.weight = new SelectList(WeightDto, "Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductWeightUnits = await _productWeightUnitsService.GetByIdAsync(Id);
            var WeightUnits = await _productWeightUnitsService.GetAllAsync();
            var WeightUnitsDto = _mapper.Map<List<ProductWeightUnitsDto>>(WeightUnits.ToList());
            ViewBag.Weight = new SelectList(WeightUnitsDto, "Name");
            return View(_mapper.Map<ProductWeightUnitsDto>(ProductWeightUnits));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productWeightUnits = await _productWeightUnitsService.GetByIdAsync(Id);
            var Weight = await _productWeightUnitsService.GetAllAsync();
            var WeightDto = _mapper.Map<List<ProductWeightUnitsDto>>(Weight.ToList());
            ViewBag.weight = new SelectList(WeightDto, "Name");
            return View(_mapper.Map<ProductWeightUnitsDto>(productWeightUnits));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductWeightUnitsDto productWeightUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productWeightUnitsService.UpdateAsync(_mapper.Map<ProductsWeightUnits>(productWeightUnitsDto));
                TempData.Add("info", "Ağırlık Birimi Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductWeightUnitsController|Update|79");

            var productWeightUnits = await _productWeightUnitsService.GetAllAsync();
            var productWeightUnitDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeightUnits.ToList());
            ViewBag.weight = new SelectList(productWeightUnitDto, "Name");
            return View(productWeightUnitsDto);
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var productWeightUnits = await _productWeightUnitsService.GetByIdAsync(Id);
            await _productWeightUnitsService.RemoveAsync(productWeightUnits);
            TempData.Add("info", "Ağırlık Birimi Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
