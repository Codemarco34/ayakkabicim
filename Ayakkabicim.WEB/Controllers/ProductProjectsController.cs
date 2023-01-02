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
    public class ProductProjectsController : Controller
    {
                        
        private readonly IProductProjectsService _productProjectsService;
    
        private readonly IMapper _mapper;

        public ProductProjectsController(IProductProjectsService productProjectsService, IMapper mapper)
        {
            _productProjectsService = productProjectsService;
            _mapper = mapper;

        }

        public async Task<IActionResult> Index()
        {
            var productProjects = await _productProjectsService.GetWebAllProductProjects();
            dynamic mymodel = new ExpandoObject();
            mymodel._productProjects = productProjects;
            mymodel._categorys = await _productProjectsService.GetWebAllProductProjects();
            mymodel.activeProductProjectsCount = productProjects.Where(t => t.IsActive == 0).Count();
            mymodel.passiveProductProjectsCount = productProjects.Where(t => t.IsActive== 1).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productProjects = await _productProjectsService.GetAllAsync();
            var productProjectsDto = _mapper.Map<List<ProductProjectDto>>(productProjects.ToList());
            ViewBag.projects = new SelectList(productProjectsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductProjectDto productProjectDto)
        {
            if (ModelState.IsValid)
            {
                await _productProjectsService.AddAsync(_mapper.Map<ProductProjects>(productProjectDto));
                TempData.Add("Success", "Proje başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductProjectsController|Save|48");
            var project = await _productProjectsService.GetAllAsync();
            var projectDto = _mapper.Map<List<ProductProjectDto>>(project.ToList());
            ViewBag.projects = new SelectList(projectDto, "Id","Name");
            return View();
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductProjects = await _productProjectsService.GetByIdAsync(Id);
            var Projects = await _productProjectsService.GetAllAsync();
            var ProductProjectsDto = _mapper.Map<List<ProductProjectDto>>(Projects.ToList());
            ViewBag.projects = new SelectList(ProductProjectsDto, "Name");
            return View(_mapper.Map<ProductProjectDto>(ProductProjects));
        }

        public async Task<IActionResult> Update(int Id)
        {
            var ProductProjects = await _productProjectsService.GetByIdAsync(Id);
            var Projects = await _productProjectsService.GetAllAsync();
            var ProductProjectsDto = _mapper.Map<List<ProductProjectDto>>(Projects.ToList());
            ViewBag.projects = new SelectList(ProductProjectsDto, "Name");
            return View(_mapper.Map<ProductProjectDto>(ProductProjects));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductProjectDto productProjectsDto)
        {
            if (ModelState.IsValid)
            {
                await _productProjectsService.UpdateAsync(_mapper.Map<ProductProjects>(productProjectsDto));
                TempData.Add("info", "Proje Güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("info", "Hata Oluştu. ProductProjectsController|Update|79");

            var productProject = await _productProjectsService.GetAllAsync();
            var productProjectDto = _mapper.Map<List<ProductProjectDto>>(productProject.ToList());
            ViewBag.projects = new SelectList(productProjectDto, "Name");
            return View(productProjectsDto);
        }


        public async Task<IActionResult> Delete(int Id)
        {
            var productProject = await _productProjectsService.GetByIdAsync(Id);
            await _productProjectsService.RemoveAsync(productProject);
            TempData.Add("info", "Proje Başarılı Şekilde Silinmiştir.");
            return RedirectToAction(nameof(Index));

        }

    }
}
