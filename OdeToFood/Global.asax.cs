using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OdeToFood.App_Start;
using AutoMapper;

namespace OdeToFood
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IMapper Mapper { get; set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper = AutoMapperConfiguration.Configure().CreateMapper();
        }
    }
}
