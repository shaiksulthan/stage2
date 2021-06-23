using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;

namespace ASPAddToCartWebSite
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //CREATE TABLE MANUALLY
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Product_Code"));
            dt.Columns.Add(new DataColumn("Product_Name"));
            dt.Columns.Add(new DataColumn("Product_Image"));
            dt.Columns.Add(new DataColumn("Product_Price"));
            dt.Columns.Add(new DataColumn("Product_QTY"));
            //ADDING RECORDS

            DataRow dr = dt.NewRow();
            dr[0] = "PRO1001";
            dr[1] = "Laptop";
            dr[2] = "~/Images/cars1.jpg";
            dr[3] = 15000;
            dr[4] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "PRO1002";
            dr[1] = "PS4";
            dr[2] = "~/Images/Ben10.png";
            dr[3] = 25000;
            dr[4] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "PRO1003";
            dr[1] = "XBOX";
            dr[2] = "~/Images/Popeye.jpg";
            dr[3] = 30000;
            dr[4] = 20;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "PRO1004";
            dr[1] = "HOLOLENS";
            dr[2] = "~/Images/Pratyush.jpg";
            dr[3] = 50000;
            dr[4] = 20;
            dt.Rows.Add(dr);

            Application.Add("Product_Catalog", dt);
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            //CREATE TABLE ADDTOCART MANUALLY
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Product_Code"));
            dt.Columns.Add(new DataColumn("Product_Name"));
            dt.Columns.Add(new DataColumn("Product_Image"));
            dt.Columns.Add(new DataColumn("Product_Price"));
            dt.Columns.Add(new DataColumn("Product_QTY"));
            dt.Columns.Add(new DataColumn("Buy_QTY"));
            dt.Columns.Add(new DataColumn("Tot_Amt"));

            Session["AddToCart"] = dt;
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

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}