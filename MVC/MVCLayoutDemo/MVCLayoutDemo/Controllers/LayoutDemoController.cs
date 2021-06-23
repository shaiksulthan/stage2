using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLayoutDemo.Controllers
{
    public class LayoutDemoController : Controller
    {
        // GET: LayoutDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserInfo()
        {
            return View();
        }
    }
}