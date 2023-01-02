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
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProductColorsService _productColorsService;
        private readonly IProductBrandsService _productBrandsService;
        private readonly IProductProjectsService _productProjectsService;
        private readonly IProductCurrencyUnitsService _productCurrencyUnitsService;
        private readonly IProductMeasurementUnitService _productMeasurementUnitsService;
        private readonly IProductVatUnitsService _productVatUnitsService;
        private readonly IProductWeightUnitsService _productWeightUnitsService;

        private readonly IProductFeaturesService _productFeaturesService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, ICategoryService categoryService,  IProductColorsService productColorsService, IProductBrandsService productBrandsService, IProductProjectsService productProjectsService, IProductCurrencyUnitsService productCurrencyUnitsService, IProductMeasurementUnitService productMeasurementUnitsService, IProductVatUnitsService productVatUnitsService, IProductWeightUnitsService productWeightUnitsService, IProductFeaturesService productFeaturesService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productColorsService = productColorsService;
            _productBrandsService = productBrandsService;
            _productProjectsService = productProjectsService;
            _productCurrencyUnitsService = productCurrencyUnitsService;
            _productMeasurementUnitsService = productMeasurementUnitsService;
            _productVatUnitsService = productVatUnitsService;
            _productWeightUnitsService = productWeightUnitsService;

            _productFeaturesService = productFeaturesService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetWebAllProductsAsync();
            var categorys = await _categoryService.GetWebAllCategoriesAsync();
            var productColors = await _productColorsService.GetWebAllProductColors();
            var productBrands = await _productBrandsService.GetWebAllProductBrands();
            var productProjects = await _productProjectsService.GetWebAllProductProjects();
            var productCurrency = await _productCurrencyUnitsService.GetWebAllCurrencyUnits();
            var productMeasurement = await _productMeasurementUnitsService.GetWebAllProductMeasurementUnits();
            var productVat = await _productVatUnitsService.GetWebAllProductVatUnits();
            var productWeight = await _productWeightUnitsService.GetWebAllProductWeightUnits();
            var productFeatures = await _productFeaturesService.GetWebAllProductFeatures();


            dynamic mymodel = new ExpandoObject();
            mymodel._products = products;
            mymodel._categorys = categorys;
            mymodel._productColors = productColors;
            mymodel._productBrands = productBrands;
            mymodel._productProjects = productProjects;
            mymodel._productCurrency = productCurrency;
            mymodel._productMeasurement = productMeasurement;
            mymodel._productVat = productVat;
            mymodel._productWeight = productWeight;
            mymodel._productFeatures = productFeatures;

            mymodel._categorys = await _categoryService.GetWebAllCategoriesAsync();
            mymodel.activeProductsCount = products.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductsCount = products.Where(t => t.IsActive== 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            
            var productColors = await _productColorsService.GetAllAsync();
            var productColorsDto = _mapper.Map<List<ProductColorsDto>>(productColors.ToList());
            ViewBag.colors = new SelectList(productColorsDto, "Id", "Name");

            var productBrands = await _productBrandsService.GetAllAsync();
            var productBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrands.ToList());
            ViewBag.brands = new SelectList(productBrandsDto, "Id", "BrandsName");

            var productProjects = await _productProjectsService.GetAllAsync();
            var productProjectsDto = _mapper.Map<List<ProductProjectDto>>(productProjects.ToList());
            ViewBag.projects = new SelectList(productProjectsDto, "Id", "Name");

            var productCurrencyUnits = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyUnitsDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrencyUnits.ToList());
            ViewBag.currency = new SelectList(productCurrencyUnitsDto, "Id", "Name");

            var productMeasurementUnits = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementUnitsDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurementUnits.ToList());
            ViewBag.measurement = new SelectList(productMeasurementUnitsDto, "Id", "Name");

            var productVatUnits = await _productVatUnitsService.GetAllAsync();
            var productVatUnitsDto = _mapper.Map<List<ProductVatUnitsDto>>(productVatUnits.ToList());
            ViewBag.vat = new SelectList(productVatUnitsDto, "Id", "Name");

            var productWeightUnits = await _productWeightUnitsService.GetAllAsync();
            var productWeightUnitsDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeightUnits.ToList());
            ViewBag.weight = new SelectList(productWeightUnitsDto, "Id", "Name");

            var categoryies = await _categoryService.GetAllAsync();
            var categoriyesDto = _mapper.Map<List<CategoryDto>>(categoryies.ToList());
            ViewBag.categories = new SelectList(categoriyesDto, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productsDto, ProductFeaturesDto productFeaturesDto)
        {
            if (ModelState.IsValid)
            {
                var _productId = await _productService.AddAsync(_mapper.Map<Products>(productsDto));
                productFeaturesDto.ProductId = _productId.Id;
                await _productFeaturesService.AddAsync(_mapper.Map<ProductFeatures>(productFeaturesDto));
                TempData.Add("Success", "Ürün Özellikleriyle birlikte eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|48");
            var categoryies = await _categoryService.GetAllAsync();
            var categoriyesDto = _mapper.Map<List<CategoryDto>>(categoryies.ToList());
            ViewBag.categories = new SelectList(categoriyesDto, "Id", "Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var products = await _productService.GetByIdAsync(Id);
            var categoryies = await _categoryService.GetAllAsync();
            var categoriyesDto = _mapper.Map<List<CategoryDto>>(categoryies.ToList());
            ViewBag.categories = new SelectList(categoriyesDto, "Id", "Name", products.CategoryId);
            return View(_mapper.Map<ProductDto>(products));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var products = await _productService.GetByIdAsync(Id);
            var categoryies = await _categoryService.GetAllAsync();
            var categoriyesDto = _mapper.Map<List<CategoryDto>>(categoryies.ToList());
            ViewBag.categories = new SelectList(categoriyesDto, "Id", "Name", products.CategoryId);
            return View(_mapper.Map<ProductDto>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductDto productsDto)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateAsync(_mapper.Map<Products>(productsDto));
                TempData.Add("info", "Ürün Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductsController|Update|79");

            var categoryies = await _categoryService.GetAllAsync();
            var categoriyesDto = _mapper.Map<List<CategoryDto>>(categoryies.ToList());
            ViewBag.categories = new SelectList(categoriyesDto, "Id", "Name", productsDto.CategoryId);
            return View(productsDto);
        }

        

        public async Task<IActionResult> Delete(int Id)
        {
            var products = await _productService.GetByIdAsync(Id);
            await _productService.RemoveAsync(products);
            TempData.Add("info", "Ürün Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
