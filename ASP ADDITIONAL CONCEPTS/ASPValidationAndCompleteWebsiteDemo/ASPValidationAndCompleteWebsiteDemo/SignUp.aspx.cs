using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPValidationAndCompleteWebsiteDemo
{
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        static string filename;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (filename!=" "|| filename!=null)
            {
                string mycon = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                con = new SqlConnection();
                con.ConnectionString = mycon;
                da = new SqlDataAdapter("select * from tblLoginDetails",con);
                ds = new DataSet();
                cmb = new SqlCommandBuilder(da);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                da.Fill(ds, "JusttblLoginDetails");
                DataRow drow = ds.Tables["JusttblLoginDetails"].NewRow();
                drow[1] = txtUserName.Text;
                drow[2] = txtRePassword.Text;
                drow[3] = txtEmail.Text;
                drow[4] = txtNo.Text;
                drow[5] = "~/Images/" + filename;
                ds.Tables["JusttblLoginDetails"].Rows.Add(drow);
                da.Update(ds, "JusttblLoginDetails");
                Response.Write("<script>alert('Registered Successfully');</script>");
                Response.Redirect("default.aspx");

        
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    string strExt = Path.GetExtension(FileUpload1.FileName);
                    //filename = Path.GetFileName(FileUpload1.FileName);When to have same file name 
                    if (strExt == ".jpg" || strExt == ".bmp" || strExt == ".png")
                    {
                        filename = "PROPIC" + DateTime.Now.ToString("ddMMyyyyHHmmss") + strExt;
                        FileUpload1.SaveAs(Server.MapPath("~/Images/") + filename);
                        ImgProfilePic.ImageUrl = "~/Images/" + filename;
                        Response.Write("<script>alert('Image upload successfully');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid image format');</script>");

                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Image not upload"+ex.Message+"');</script>");

            }

        }
    }
}