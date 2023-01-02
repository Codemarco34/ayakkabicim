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
    public class ProductMeasurementUnitsController : Controller
    {
                        
        private readonly IProductMeasurementUnitService _productMeasurementUnitsService;
    
        private readonly IMapper _mapper;

        public ProductMeasurementUnitsController(IProductMeasurementUnitService productMeasurementUnitsService, IMapper mapper)
        {
            _productMeasurementUnitsService = productMeasurementUnitsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productMeasurementUnits = await _productMeasurementUnitsService.GetWebAllProductMeasurementUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productMeasurementUnits = productMeasurementUnits;
            mymodel._categorys = await _productMeasurementUnitsService.GetWebAllProductMeasurementUnits();
            mymodel.activeProductMeasurementUnitsCount = productMeasurementUnits.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductMeasurementUnitsCount = productMeasurementUnits.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productMeasurementUnits = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementUnitsDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurementUnits.ToList());
            ViewBag.measurement = new SelectList(productMeasurementUnitsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productMeasurementUnitsService.AddAsync(_mapper.Map<ProductMeasurementUnits>(productMeasurementUnitsDto));
                TempData.Add("Success", "Ölçü Birimi başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductMeasurementUnitsController|Save|48");
            var measurement = await _productMeasurementUnitsService.GetAllAsync();
            var MeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(measurement.ToList());
            ViewBag.measurement = new SelectList(MeasurementDto, "Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductMeasurementUnits = await _productMeasurementUnitsService.GetByIdAsync(Id);
            var MeasurementUnits = await _productMeasurementUnitsService.GetAllAsync();
            var MeasurementUnitsDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(MeasurementUnits.ToList());
            ViewBag.measurement = new SelectList(MeasurementUnitsDto, "Name");
            return View(_mapper.Map<ProductMeasurementUnitsDto>(ProductMeasurementUnits));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productMeasurementUnits = await _productMeasurementUnitsService.GetByIdAsync(Id);
            var Measurement = await _productMeasurementUnitsService.GetAllAsync();
            var MeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(Measurement.ToList());
            ViewBag.measurement = new SelectList(MeasurementDto, "Name");
            return View(_mapper.Map<ProductMeasurementUnitsDto>(productMeasurementUnits));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productMeasurementUnitsService.UpdateAsync(_mapper.Map<ProductMeasurementUnits>(productMeasurementUnitsDto));
                TempData.Add("info", "Ölçü Birimi Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductMeasurementUnitsController|Update|79");

            var productMeasurementUnits = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementUnitDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurementUnits.ToList());
            ViewBag.measurement = new SelectList(productMeasurementUnitDto, "Name");
            return View(productMeasurementUnitsDto);
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var productMeasurementUnits = await _productMeasurementUnitsService.GetByIdAsync(Id);
            await _productMeasurementUnitsService.RemoveAsync(productMeasurementUnits);
            TempData.Add("info", "Ölçü Birimi Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
