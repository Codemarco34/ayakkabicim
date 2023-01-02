using Autofac;
using System.Reflection;
using Ayakkabicim.Core.Repositories;
using Ayakkabicim.Service.Services;
using Ayakkabicim.Core.Services;
using Ayakkabicim.Repository.UnitOfWorks;
using FluentValidation;
using Module = Autofac.Module;
using Ayakkabicim.Core.UnityOfWorks;
using Ayakkabicim.Repository.Repositories;
using Autofac.Extensions.DependencyInjection;
using Ayakkabicim.Service.Mappings;

namespace Gorevcim.API.Modules
{
    public class RepositoryServicesModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<ProductColorsRepository>().As<IProductColorsRepository>();
            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();

            var repository = Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();


            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


        }

    }
}
