using System.Web.Http;
using Unity;
using Unity.WebApi;
using Vile_ASPNET_WebAPI_MongoDB.DataAccess;
using Vile_ASPNET_WebAPI_MongoDB.Models;
using Vile_ASPNET_WebAPI_MongoDB.Repositories;

namespace Vile_ASPNET_WebAPI_MongoDB
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterSingleton<ProductManagementDbContext>();
            container.RegisterType<BookStoreDatabaseSettings>();
            container.RegisterType<IBookRepository, BookRepository>();
            container.RegisterSingleton<ExternalApiInfo>();
            container.RegisterType<ISlideRepository, SlideRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}