﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ASPValidationAndCompleteWebsiteDemo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("UserOnline", 0);

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["UserOnline"] = Convert.ToInt32(Application["UserOnline"]) + 1;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("Errors.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["UserOnline"] = Convert.ToInt32(Application["UserOnline"]) - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}