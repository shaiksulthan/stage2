using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandlingDemo.Controllers
{
    public class SecondController : BaseController
    {
        // GET: Second
        public ActionResult Index()
        {
            int i = 0, num = 10;
            i = num / i;
            return View();

        }
    }
}