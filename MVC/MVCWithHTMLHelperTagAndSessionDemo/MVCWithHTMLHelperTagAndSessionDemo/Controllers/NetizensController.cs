using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithHTMLHelperTagAndSessionDemo.Models;

namespace MVCWithHTMLHelperTagAndSessionDemo.Controllers
{
    public class NetizensController : Controller
    {
        public static List<NetizensUser> ListnetizensUsers = new List<NetizensUser>()
        {
            new NetizensUser()
            {
                UserId=1001,
                UserName ="Sanchayeta",
                Password = "San@123",
                EmailId="sanch@yeta.com",
                Contact = "8888888888"
            }

        };


        // GET: Netizens
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(NetizensUser netizensUser)
        {
            if (ListnetizensUsers.Count == 0)
            {
                netizensUser.UserId = 1001;
                ListnetizensUsers.Add(netizensUser);
            }
            else
            {
                int id = ListnetizensUsers.Max(x => x.UserId);
                netizensUser.UserId = id + 1;
                ListnetizensUsers.Add(netizensUser);

            }

            return View("Index");
        }

        [HttpPost]
        public ActionResult Login(NetizensUser netizensUser)
        {
            NetizensUser netizens =
                ListnetizensUsers.FirstOrDefault(x => x.EmailId == netizensUser.EmailId && x.Password == netizensUser.Password);
            if (netizens == null)
            {
                ViewData["Valid"] = "Invalid user name password";
                return View("Index");
            }
            else
            {
                Session["UserId"] = netizens.UserId;
                return View("Home", netizens);
            }


        }

        [HttpGet]
        public ActionResult Home()
        {
            if (Session["UserId"] == null)
            {
                return View("Index");
            }
            else
            {
                NetizensUser netizens = ListnetizensUsers.FirstOrDefault(x => x.UserId == Convert.ToInt32(Session["UserId"]));
                return View(netizens);
            }

        }
        [HttpGet]
        public ActionResult EditProfile()
        {
            NetizensUser netizens = ListnetizensUsers.FirstOrDefault(x => x.UserId == Convert.ToInt32(Session["UserId"]));


            return View(netizens);


        }
        [HttpPost]
        public ActionResult EditProfile(NetizensUser netizensUser)
        {
            NetizensUser netizens = ListnetizensUsers.FirstOrDefault(x => x.UserId == Convert.ToInt32(Session["UserId"]));
            netizens.UserName = netizensUser.UserName;
            netizens.Password = netizensUser.Password;
            netizens.EmailId = netizensUser.EmailId;
            netizens.Contact = netizensUser.Contact;
            return View("Home", netizens);


        }
        [HttpGet]
        public ActionResult DeleteProfile()
        {
            Session.Abandon();
            NetizensUser netizens = ListnetizensUsers.FirstOrDefault(x => x.UserId == Convert.ToInt32(Session["UserId"]));
            ListnetizensUsers.Remove(netizens);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();

            return View("Index");
        }
    }
}