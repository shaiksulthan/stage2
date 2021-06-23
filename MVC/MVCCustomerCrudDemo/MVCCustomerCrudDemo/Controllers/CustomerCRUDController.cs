using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCustomerCrudDemo.Models;

namespace MVCCustomerCrudDemo.Controllers
{
    public class CustomerCRUDController : Controller
    {

        static List<Customer> customers = new List<Customer>()
            {
                new Customer()
                { CustomerId=1001,
                CustomerName="Abhishek",
                Email="abhi@yahoo.com",
                Contact="+918888888888",
                City="Delhi"
                },
                new Customer()
                { CustomerId=1002,
                CustomerName="Vidhi",
                Email="Vidhi@yahoo.com",
                Contact="+918888888888",
                City="Kolkata"
                }
            };
        // GET: CustomerCRUD
        [HttpGet]
        public ActionResult Index()
        {

            return View(customers);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer customer = customers.FirstOrDefault(c => c.CustomerId == id);

            return View(customer);
            
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            customers.Add(customer);

            return View("Index", customers);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {

            Customer cust = customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            cust.CustomerId = customer.CustomerId;
            cust.CustomerName = customer.CustomerName;
            cust.Email = customer.Email;
            cust.Contact = customer.Contact;
            cust.City = customer.City;

            return View("Index", customers);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Customer customer = customers.FirstOrDefault(c => c.CustomerId == id);

            return View(customer);


        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Customer cust = customers.FirstOrDefault(c => c.CustomerId == id);
            customers.Remove(cust);
            return View("Index", customers);
        }



    }
}