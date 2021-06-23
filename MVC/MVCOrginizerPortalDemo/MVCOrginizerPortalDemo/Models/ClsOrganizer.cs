using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCOrginizerPortalDemo.Models
{
    public class ClsOrganizer
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime  EventDate { get; set; }
        public string EventHostName { get; set; }
        public string EventLocation { get; set; }


    }
}