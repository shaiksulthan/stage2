using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Diagnostics;

namespace MVCActionFilterDemo.Controllers
{

    //ATTRIBUTE ACTION FILTER DEMO
    public class MyActionFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Post process logic
            //  Trace.WriteLine("Action has Executed at " + DateTime.Now.ToString());
            //This will give you action name  / view name in the log file
            Trace.WriteLine(filterContext.ActionDescriptor.ActionName + "Action has Executed at " + DateTime.Now.ToString());

        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Pre processing logic
            //filterContext.Result = new RedirectResult("http://www.google.com");
            Trace.WriteLine(filterContext.ActionDescriptor.ActionName + "Action has Executing at " + DateTime.Now.ToString());
        }


    }
    [MyActionFilter]
    public class ActionFilterAttributeDemoController : Controller
    {
        // GET: ActionFilterAttributeDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyIndex()
        {
            return View();
        }
    }
}