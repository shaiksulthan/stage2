using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAuthenticationAndAuthorizationDemo.Models;
using System.Web.Security;

namespace MVCAuthenticationAndAuthorizationDemo.Controllers
{
    [Authorize(Users = @"DESKTOP-BLC9DN3\abhi")]
    public class HomeController : Controller
    {

        // GET: Home
        static List<ClsCustomer> Customers = new List<ClsCustomer>()
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
        [HttpGet]
        [Authorize(Users = @"DESKTOP-BLC9DN3\abhi")]
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        [Authorize(Users = @"DESKTOP-BLC9DN3\abhi")]
        public ActionResult CustomerDetails()
        {
            var Customer = Customers.FirstOrDefault(c => c.CustName == "Mahantesh" && c.Password == "mahantesh@123");

            return View(Customer);
        }


    }
}