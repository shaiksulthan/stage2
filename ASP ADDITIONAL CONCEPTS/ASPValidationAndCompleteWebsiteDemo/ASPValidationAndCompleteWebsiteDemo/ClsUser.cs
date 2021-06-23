using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPValidationAndCompleteWebsiteDemo
{
    [Serializable]
    public class ClsUser
    {
        public int  LoginId  { get; set; }
        public string  UserName { get; set; }
        public string  Email  { get; set; }
        public string  ContactNo { get; set; }
        public string ProfilePic { get; set; }


    }
}