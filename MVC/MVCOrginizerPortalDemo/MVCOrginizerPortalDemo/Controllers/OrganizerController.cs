using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOrginizerPortalDemo.Models;
namespace MVCOrginizerPortalDemo.Controllers
{
    public class OrganizerController : Controller
    {
        // GET: Organizer
        public static List<ClsOrganizer> EventList = new List<ClsOrganizer>()
        {
            new ClsOrganizer(){
                EventID=1,
                EventName="Mahantest Reception",
                EventDate=new DateTime(2020,06,23),
                EventHostName = "Mahantest",
                EventLocation="Chennai"
            }

        };
        //GET : INDEX
        public ActionResult Index()
        {

            return View(EventList);
        }
        [HttpGet]
        public ActionResult AddEvent()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddEvent(ClsOrganizer clsOrganizer)
        {
            if (EventList.Count==0)
            {
                clsOrganizer.EventID = 1;
                EventList.Add(clsOrganizer);
              return  View("Index", EventList);

            }
            else
            {
                int i = EventList.Max(e => e.EventID);
                clsOrganizer.EventID = i+1;
                EventList.Add(clsOrganizer);
               return View("Index", EventList);

            }



          
        }



        [HttpGet]
        public ActionResult EditEvent(int Id)
        {
            ClsOrganizer clsOrganizer = EventList.FirstOrDefault(e => e.EventID == Id);


            return View(clsOrganizer);
        }
        [HttpPost]
        public ActionResult EditEvent(ClsOrganizer clsOrganizer)
        {
            ClsOrganizer obj  = EventList.FirstOrDefault(e => e.EventID == clsOrganizer.EventID);
            obj.EventName = clsOrganizer.EventName;
            obj.EventDate = clsOrganizer.EventDate;
            obj.EventHostName = clsOrganizer.EventHostName;
            obj.EventLocation = clsOrganizer.EventLocation;

            return View("Index", EventList);
        }

        [HttpGet]
        public ActionResult DeleteEvent(int Id)
        {
            ClsOrganizer clsOrganizer = EventList.FirstOrDefault(e => e.EventID == Id);
            EventList.Remove(clsOrganizer);

            return View("Index", EventList);
        }
    }
}