using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MVCFormAuthenticationDemo.Models;


namespace MVCFormAuthenticationDemo.Controllers
{
   
    public class HomeController : Controller
    {
        public static List<ClsCustomer> Customers = new List<ClsCustomer>()
        {
            new ClsCustomer()
            {
                CustCode=1001,
                CustName="Sushil",
                Amount=1234.56,
                Email="sushil.lnu@gmail.com",
                Password="sushil@123"
            },
             new ClsCustomer()
            {
                CustCode=1002,
                CustName="Mahantesh",
                Amount=1234.56,
                Email="mahantesh.g@gmail.com",
                Password="mahantesh@123"
            }

        };

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Authorize]
        public ActionResult ValidateCustomer(ClsCustomer clsCustomer)
        {
            var customer = Customers.FirstOrDefault(c => c.Email == clsCustomer.Email && c.Password == clsCustomer.Password);
            if (customer == null)
            {

                return RedirectToAction("Index");
            }
            else
            {
                FormsAuthentication.SetAuthCookie("Cookie", true);
                return View("CustomerDetails", customer);
            }


        }

        [HttpGet]
        public ActionResult CustomerDetails(ClsCustomer clsCustomer)
        {
            return View(clsCustomer);
        }



    }
}