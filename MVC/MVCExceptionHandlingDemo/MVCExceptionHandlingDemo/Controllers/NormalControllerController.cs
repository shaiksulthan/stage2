using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExceptionHandlingDemo.Models;
namespace MVCExceptionHandlingDemo.Controllers
{
    public class NormalControllerController : Controller
    {
        // GET: NormalController
        //[HandleError]
        //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DError")]
        //[HandleError(ExceptionType = typeof(NullReferenceException), View = "NRError")]
        [MyCustomExFilter]
        public ActionResult Index()
        {
            ClsEmployee emp = new ClsEmployee();
            emp = null;
            emp.Show();

            int i = 0, num = 10;
            i = num / i;
            return View();

           
        }

        public ActionResult WelcomeUser()
        {

            return View();
        }
    }
}