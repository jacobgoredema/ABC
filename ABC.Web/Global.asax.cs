using ABC.BusinessLayer.DependancyResolver.Ninject;
using ABC.Core.Utilities.Mvc.Infrastructure.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ABC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(
                new NinjectControllerFactory(new BusinessModule()));
        }
    }
}
