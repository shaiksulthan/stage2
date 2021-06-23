using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCExceptionHandlingDemo
{

    public class MyCustomExFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            ViewResult v = new ViewResult();
            v.ViewName = "Error2";
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
            Exception e = filterContext.Exception;
        }

    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //Application["UserOnLine"] = 0;


            //To show the default error message 
           // GlobalFilters.Filters.Add(new HandleErrorAttribute());
           GlobalFilters.Filters.Add(new MyCustomExFilter());

        }

        protected void Session_Start()
        {
            int i = Convert.ToInt32(Application["UserOnLine"]) + 1;
            Application["UserOnLine"] = i;

            Session["Greeting"] = "Hello";
          
        }

        protected void Session_End()
        {
            int i = Convert.ToInt32(Application["UserOnLine"]) - 1;
            Application["UserOnLine"] = i;

           
        }
        protected void Application_End()
        {
          

        }

    }
}
