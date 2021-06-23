using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ASPValidationAndCompleteWebsiteDemo
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDetails.Text = "User Online :- " + Application["UserOnline"].ToString();
            lblDetails.Text += "<br/> Session ID :- " + Session.SessionID.ToString();
            lblDetails.Text += "<br/> Session Time out :- " + Session.Timeout.ToString();
            lblDetails.Text += "<br/> Session Mode :- " + Session.Mode.ToString();

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string mycon = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = mycon;
            con.Open();
            com = new SqlCommand("select * from tblLoginDetails where Email=@Email and UserPassword=@UserPassword", con);
            com.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtUserName.Text;
            com.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = txtPassword.Text;
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Session["SLoginId"] = dr["LoginId"].ToString();
                Session["SUserName"] = dr["UserName"].ToString();
                Session["SEmail"] = dr["Email"].ToString();
                Session["SContactNo"] = dr["ContactNo"].ToString();
                Session["SProfilePic"] = dr["ProfilePic"].ToString();
                ClsUser obj = new ClsUser();
                obj.LoginId = Convert.ToInt32(dr["LoginId"]);
                obj.UserName= dr["UserName"].ToString();
                Session["MyClass"] = obj;
                dr.Close();
                com.Dispose();
                con.Close();
                Response.Redirect("AfterLoginPage.aspx");

            }
            else
            {
                lblMessage.Text = "Invalid User Name or Password";
            }
            

        }
    }
}