using Autofac;
using System.Reflection;
using Ayakkabicim.Service.Mappings;
using Ayakkabicim.Repository.Repositories;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Service.Services;
using Ayakkabicim.Core.Services;
using Microsoft.EntityFrameworkCore;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.UnitOfWorks;
using FluentValidation;
using Module = Autofac.Module;
using Autofac.Extensions.DependencyInjection;
using Ayakkabicim.Core;
using Microsoft.AspNetCore.Mvc;
using Ayakkabicim.Repository.GenericRepositories;
using Ayakkabicim.Core.Models;

namespace Ayakkabicim.WEB.Modules
{
    public class RepositoryServicesModules: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository.Repositories.GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();
            builder.RegisterType<ProductColorsRepository>().As<IProductColorsRepository>();
            builder.RegisterType<ProductBrandsRepository>().As<IProductBrandsRepository>();
            builder.RegisterType<ProductCurencyUnitsRepository >().As<IProductCurrencyUnitsRepository>();
            builder.RegisterType<ProductMeasurementUnitsRepository>().As<IProductMeasurementUnitsRepository>();
            builder.RegisterType<ProductProjectsRepository>().As<IProductProjectsRepository>();
            builder.RegisterType<ProductVatUnitsRepository>().As<IProductVatUnitsRepository>();
            builder.RegisterType<ProductWeightUnitsRepository>().As<IProductWeightUnitsRepository>();
            builder.RegisterType<ProductFeaturesRepository>().As<IProductFeaturesRepository>();


            builder.RegisterType<CompanyFirmaRepository>().As<ICompanyFirmaRepository>();
            builder.RegisterType<CompanySubeRepository>().As<ICompanySubeRepository>();
            builder.RegisterType<CompanyBayiRepository>().As<ICompanyBayiRepository>();


            var repository = Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();


            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }

    }
}
