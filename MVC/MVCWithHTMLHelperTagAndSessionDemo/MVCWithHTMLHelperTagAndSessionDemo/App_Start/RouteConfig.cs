using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCWithHTMLHelperTagAndSessionDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

       
            routes.MapRoute(
             name: "NetDetails",
             url: "Netizens/Neties/{id}",
             defaults: new { controller = "Netizens", action = "Login", id = UrlParameter.Optional }
         );

            routes.MapRoute(
              name: "NetEdit",
              url: "Netizens/Edit/{id}",
              defaults: new { controller = "Netizens", action = "EditProfile", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "NetHome",
               url: "Netizens/Home/{id}",
               defaults: new { controller = "Netizens", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
