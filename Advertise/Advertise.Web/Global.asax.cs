﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Advertise.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            EfConfig.RegisterEf();
        }
    }
}
