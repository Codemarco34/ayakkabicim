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
    public class ProductColorsController : Controller
    {
                        
        private readonly IProductColorsService _productColorsService;
    
        private readonly IMapper _mapper;

        public ProductColorsController(IProductColorsService productColorsService, IMapper mapper)
        {
            _productColorsService = productColorsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productColors = await _productColorsService.GetWebAllProductColors();
            dynamic mymodel = new ExpandoObject();
            mymodel._productColors = productColors;
            mymodel._categorys = await _productColorsService.GetWebAllProductColors();
            mymodel.activeProductColorsCount = productColors.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductColorsCount = productColors.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productColors = await _productColorsService.GetAllAsync();
            var productColorsDto = _mapper.Map<List<ProductColorsDto>>(productColors.ToList());
            ViewBag.colors = new SelectList(productColorsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductColorsDto productsColorDto)
        {
            if (ModelState.IsValid)
            {
                await _productColorsService.AddAsync(_mapper.Map<ProductColors>(productsColorDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|48");
            var colors = await _productColorsService.GetAllAsync();
            var ColorsDto = _mapper.Map<List<ProductColorsDto>>(colors.ToList());
            ViewBag.colors = new SelectList(ColorsDto ,"Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductColors = await _productColorsService.GetByIdAsync(Id);
            var Colors = await _productColorsService.GetAllAsync();
            var ColorsDto = _mapper.Map<List<ProductColorsDto>>(Colors.ToList());
            ViewBag.colors = new SelectList(ColorsDto, "Name");
            return View(_mapper.Map<ProductColorsDto>(ProductColors));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productsColors = await _productColorsService.GetByIdAsync(Id);
            var Colors = await _productColorsService.GetAllAsync();
            var ColorsDto = _mapper.Map<List<ProductColorsDto>>(Colors.ToList());
            ViewBag.colors = new SelectList(ColorsDto,"Name");
            return View(_mapper.Map<ProductColorsDto>(productsColors));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductColorsDto productsColorDto)
        {
            if (ModelState.IsValid)
            {
                await _productColorsService.UpdateAsync(_mapper.Map<ProductColors>(productsColorDto));
                TempData.Add("info", "Ürün Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductsController|Update|79");

            var productsColor = await _productColorsService.GetAllAsync();
            var productsColorsDto = _mapper.Map<List<ProductColorsDto>>(productsColor.ToList());
            ViewBag.colors = new SelectList(productsColorsDto, "Name");
            return View(productsColorDto);
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var products = await _productColorsService.GetByIdAsync(Id);
            await _productColorsService.RemoveAsync(products);
            TempData.Add("info", "Ürün Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
