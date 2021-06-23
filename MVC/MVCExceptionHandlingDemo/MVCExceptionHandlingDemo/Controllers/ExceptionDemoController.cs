using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandlingDemo.Controllers
{

    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            ViewResult v = new ViewResult();
            v.ViewName = "Error";
            filterContext.Result = v;
            filterContext.ExceptionHandled = true;
        }

    }
    public class ExceptionDemoController : BaseController    // Controller
    {
        //APPROACH 1//DRY : DO NOT REPEAT YOURSELF
        //protected override void OnException(ExceptionContext filterContext)

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    ViewResult v = new ViewResult();
        //    v.ViewName = "Error";
        //    filterContext.Result = v;
        //    filterContext.ExceptionHandled = true;
        //}

        // GET: ExceptionDemo
        public ActionResult Index()
        {
            //try
            //{
                int i = 0, num = 10;
                i = num / i;
                return View();
            //}
            //catch (Exception e)
            //{

            //    return View("Error");
            //}


        }
        public ActionResult Index2()
        {
            //try
            //{
                int i = 0, num = 10;
                i = num / i;
                return View();
            //}
            //catch (Exception e)
            //{

            //    return View("Error");
            //}


        }
    }
}