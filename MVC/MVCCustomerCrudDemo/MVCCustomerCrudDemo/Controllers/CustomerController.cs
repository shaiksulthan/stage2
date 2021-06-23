using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCustomerCrudDemo.Models;

namespace MVCCustomerCrudDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateCustomer()
        {
            return View();
        }

        public ActionResult ShowDetails()
        {

            ViewData["DTime"] = DateTime.Now;
            // ViewData["CustomerName"] = "Abhishek";

            //ViewBag.CustomerName = "Abhishek";
            //ViewBag.City = "Delhi";

            ViewData["CustomerId"] = Request.Form["CustomerId"];

            //ViewBag.CustomerId = Request.Form["CustomerId"];
            ViewBag.CustomerName = Request.Form["CustomerName"];
            ////ViewData["CustomerName"] = Request.Form["CustomerName"];
            ViewData["Email"] = Request.Form["Email"];
            ViewData["Contact"] = Request.Form["Contact"];
            ViewData["City"] = Request.Form["City"];
            //ViewData["Name"] = "Abhishek";
            return View();


        }
        //Strongly type view : When the class tightly 
        public ActionResult ShowCustomerDetails()
        {
            Customer obj = new Customer();
            obj.CustomerId = Convert.ToInt32(Request.Form["CustomerId"]);
            obj.CustomerName = Request.Form["CustomerName"];
            obj.Email = Request.Form["Email"];
            obj.Contact = Request.Form["Contact"];
            obj.City = Request.Form["City"];


            return View(obj);
        }

        public ActionResult ShowCustomerDetailsDI(Customer customer)
        {

            return View(customer);
        }
    }
}