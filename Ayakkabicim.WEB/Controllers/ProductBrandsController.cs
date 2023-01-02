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
    public class ProductBrandsController : Controller
    {
                        
        private readonly IProductBrandsService _productBrandsService;
    
        private readonly IMapper _mapper;

        public ProductBrandsController(IProductBrandsService productBrandsService, IMapper mapper)
        {

            _productBrandsService = productBrandsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productBrands = await _productBrandsService.GetWebAllProductBrands();
            dynamic mymodel = new ExpandoObject();
            mymodel._productBrands = productBrands;
            mymodel._categorys = await _productBrandsService.GetWebAllProductBrands();
            mymodel.activeProductBrandsCount = productBrands.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductBrandsCount = productBrands.Where(t => t.IsActive== 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productBrands = await _productBrandsService.GetAllAsync();
            var productBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrands.ToList());
            ViewBag.brands = new SelectList(productBrandsDto, "Id", "BrandsName");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductBrandsDto productsBrandsDto)
        {
            if (ModelState.IsValid)
            {
                await _productBrandsService.AddAsync(_mapper.Map<ProductBrands>(productsBrandsDto));
                TempData.Add("Success", "Marka başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|48");
            var Brands = await _productBrandsService.GetAllAsync();
            var BrandsDto = _mapper.Map<List<ProductBrandsDto>>(Brands.ToList());
            ViewBag.brands = new SelectList(BrandsDto, "BrandsName");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductBrands = await _productBrandsService.GetByIdAsync(Id);
            var Brands = await _productBrandsService.GetAllAsync();
            var BrandsDto = _mapper.Map<List<ProductBrandsDto>>(Brands.ToList());
            ViewBag.brands = new SelectList(BrandsDto, "BrandsName");
            return View(_mapper.Map<ProductBrandsDto>(ProductBrands));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productsBrands = await _productBrandsService.GetByIdAsync(Id);
            var Brands = await _productBrandsService.GetAllAsync();
            var BrandsDto = _mapper.Map<List<ProductBrandsDto>>(Brands.ToList());
            ViewBag.brands = new SelectList(BrandsDto, "BrandsName");
            return View(_mapper.Map<ProductBrandsDto>(productsBrands));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductBrandsDto productsBrandsDto)
        {
            if (ModelState.IsValid)
            {
                await _productBrandsService.UpdateAsync(_mapper.Map<ProductBrands>(productsBrandsDto));
                TempData.Add("info", "Marka Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|48");
            var Brands = await _productBrandsService.GetAllAsync();
            var BrandsDto = _mapper.Map<List<ProductBrandsDto>>(Brands.ToList());
            ViewBag.brands = new SelectList(BrandsDto, "BrandsName");
            return View();
        }



        public async Task<IActionResult> Delete(int Id)
        {
            var brands = await _productBrandsService.GetByIdAsync(Id);
            await _productBrandsService.RemoveAsync(brands);
            TempData.Add("info", "Ürün Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
