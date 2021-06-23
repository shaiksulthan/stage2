using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCActionResultAndViewResultDemo.Models;

namespace MVCActionResultAndViewResultDemo.Controllers
{
    public class CustomerDemoController : Controller
    {
    
        // GET: CustomerDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadCustomer()
        {
            ClsCustomer Obj = new ClsCustomer()
            {
                CustCode = 1001,
                CustName = "Mahantesh",
                CustAmount = 1234.56
            };
            return View(Obj);

        }
        public ActionResult LoadCustomerJson()
        {
            ClsCustomer Obj = new ClsCustomer()
            {
                CustCode = 1001,
                CustName = "Mahantesh",
                CustAmount = 1234.56
            };
            //return View(Obj);
            return Json(Obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GenericLoadCustomer()
        {
            ClsCustomer Obj = new ClsCustomer()
            {
                CustCode = 1001,
                CustName = "Mahantesh",
                CustAmount = 1234.56
            };
            if (Request.QueryString["OutputType"] == "HTML")
            {
               
                return View("LoadCustomer", Obj);

            }
            else
            {
                return Json(Obj, JsonRequestBehavior.AllowGet);
            }

            //return View(Obj);

        }

        public ActionResult DisplayEmployee()
        {

            return View("ConsumeEmployee");
        }
    }
}