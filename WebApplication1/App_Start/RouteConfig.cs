using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "Person/all",
                defaults: new { controller = "Person", action = "all" }
            );
            routes.MapRoute(
                name: "route2",
                url: "Person/search",
                defaults: new { controller = "Person", action = "search" }
            );
            routes.MapRoute(
               name: "route3",
               url: "Person/GetPerson",
               defaults: new { controller = "Person", action = "GetPerson" }
           );
            routes.MapRoute(
               name: "route",
               url: "{controller}/{id}",
               defaults: new { controller = "Person", action = "person", id = UrlParameter.Optional }
           );

            

            
        }
    }
}
