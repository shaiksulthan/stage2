using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPartialViewDemo.Models;

namespace MVCPartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public static List<NetizensUser> ListnetizensUsers = new List<NetizensUser>()
        {
            new NetizensUser()
            {
                UserId=1001,
                UserName ="Sanchayeta",
                Password = "San@123",
                EmailId="sanch@yeta.com",
                Contact = "8888888888"
            },
            new NetizensUser()
            {
                UserId=1002,
                UserName ="Mahantesh",
                Password = "man@123",
                EmailId="mahantesh@gmail.com",
                Contact = "8888888888"
            }

        };

        public ActionResult UserDetails()
        {

            return View(ListnetizensUsers);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}