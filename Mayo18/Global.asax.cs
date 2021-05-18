using Mayo18.DB;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mayo18
{
    [ExcludeFromCodeCoverage]
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //BOILERPLATE

            // desde https://docs.simpleinjector.org/en/latest/mvcintegration.html
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<ISakila, Sakila>(Lifestyle.Scoped);
            // inyectar en el controlador
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            // inyectar en el controlador
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}
