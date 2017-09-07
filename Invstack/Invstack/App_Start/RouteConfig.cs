using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Invstack
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
            
            //routes.MapRoute(
            //    name: "Articles",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Article", action = "Index", id = UrlParameter.Optional }
            //);
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Questions", action = "Index", id = UrlParameter.Optional }
            //);

            
        }
    }
}
