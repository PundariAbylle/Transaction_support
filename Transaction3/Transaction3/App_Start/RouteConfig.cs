using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Transaction3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Default",
               url: "",
               defaults: new { controller = "Home", action = "DisplayReport", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "RedirectToSubreport",
            url: "Home/RedirectToSubreport",
            defaults: new { controller = "Home", action = "RedirectToSubreport" }
            );

            routes.MapRoute(
                name: "Subreport",
                url: "Home/SubreportABP",
                defaults: new { controller = "Home", action = "SubreportABP" }
            );

            routes.MapRoute(
                name: "DefaultFallback",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
