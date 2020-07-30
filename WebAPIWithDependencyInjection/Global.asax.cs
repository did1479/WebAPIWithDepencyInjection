using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector;
using WebApiDependencyInjection.App_Start;
using WebAPIWithDependencyInjection.BusinessAccess.interfaces;
using WebAPIWithDependencyInjection.BusinessAccess.manager;
using WebAPIWithDependencyInjection.DataAccess.interfaces;
using WebAPIWithDependencyInjection.DataAccess.manager;

namespace WebAPIWithDependencyInjection
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new Container();
            container.Register<IDataAccessLayer, DataAccessManager>();
            container.Register<IBusinessAccessLayer, BusinessAccessManager>();

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);
        }
    }
}
