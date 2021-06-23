using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
namespace MVCActionFilterDemo.Controllers
{
    //INLINE ACTION FILTER DEMO
    public class ActionFilterDemoController : Controller, IActionFilter
    {
        // GET: ActionFilterDemo
        public ActionResult Index()
        {

            return View();
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Post process logic
            Trace.WriteLine("Action has Executed at " + DateTime.Now.ToString());

        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Pre processing logic
            Trace.WriteLine("Action has Executing at " + DateTime.Now.ToString());
        }

    }
}