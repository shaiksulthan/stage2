using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPValidationAndCompleteWebsiteDemo
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUsPag.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnContactUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUsPage.aspx");
        }
    }
}