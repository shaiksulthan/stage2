using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPValidationAndCompleteWebsiteDemo
{
    public partial class AfterLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["SLoginId"]!=null)
            {
                lblName.Text = Session["SUserName"].ToString();
                lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                ImgProfilePic.ImageUrl = Session["SProfilePic"].ToString();
                ClsUser obj = Session["MyClass"] as ClsUser;
                Label1.Text = obj.LoginId + " " + obj.UserName;

               



            }
            else
            {
                Response.Write("<script>alert('Session Expired ...Login again');</script>");
                Response.Redirect("default.aspx");
                 
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("default.aspx");
        }
    }
}