using POCDynamicUI.Component;
using POCDynamicUI.Controllers;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace POCDynamicUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
           
            container.RegisterType<IFormDataComponent, FormDataComponent>();
            container.RegisterType<IUserComponent, UserComponent>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}