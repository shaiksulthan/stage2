using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCEmployeeCrudOperationInMemoryRepository
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ShowEmployees",
               url: "EmployeePortal/Employees/{id}",
               defaults: new { controller = "EmployeeCrud", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "EditEmployee",
               url: "EmployeePortal/EditEmployee/{id}",
               defaults: new { controller = "EmployeeCrud", action = "EditEmployee", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "EmployeeDetails",
              url: "EmployeePortal/EmployeeInfo/{id}",
              defaults: new { controller = "EmployeeCrud", action = "EmployeeDetails", id = 1001}
          );

            routes.MapRoute(
             name: "EmployeeDelete",
             url: "EmployeePortal/EmployeeRemove/{id}",
             defaults: new { controller = "EmployeeCrud", action = "DeleteEmployee", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
