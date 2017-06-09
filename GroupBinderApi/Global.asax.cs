using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using GroupBinderApi.Logic;
using GroupBinderApi.Logic.Models;

namespace GroupBinderApi
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            HttpContext.Current.Application["GroupBinderContext"] = new GroupBinderContext();
            InitializeWithFakeUsers();
        }

        private static void InitializeWithFakeUsers()
        {
            AppContext.SaveUserLocation("691608245", 54.3827261, 18.6239686);
            AppContext.SaveUserLocation("531621685", 54.3738065, 18.6129093);
        }
    }
}
