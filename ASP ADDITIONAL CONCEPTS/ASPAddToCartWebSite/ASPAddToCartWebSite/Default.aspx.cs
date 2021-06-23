using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASPAddToCartWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = Application["Product_Catalog"] as DataTable;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = Session["AddToCart"] as DataTable;
            Label L1 = GridView1.SelectedRow.Cells[1].FindControl("lblProductCode") as Label;
            Label L2 = GridView1.SelectedRow.Cells[2].FindControl("lblProductName") as Label;
            Label L3 = GridView1.SelectedRow.Cells[3].FindControl("lblProductPrice") as Label;
            Label L4 = GridView1.SelectedRow.Cells[4].FindControl("lblProductQTY") as Label;
            Image I1 = GridView1.SelectedRow.Cells[5].FindControl("imgProductImage") as Image;
            TextBox T1 = GridView1.SelectedRow.Cells[6].FindControl("txtQty") as TextBox;

            DataRow drow = dt.NewRow();
            drow[0] = L1.Text;
            drow[1] = L2.Text;
            drow[2] = I1.ImageUrl;
            drow[3] = L3.Text;
            drow[4] = L4.Text;
            drow[5] = T1.Text;
            drow[6] = Convert.ToInt32(L3.Text.Trim()) * Convert.ToInt32(T1.Text.Trim());
            dt.Rows.Add(drow);

            Session["AddToCart"] = dt;


        }

        protected void btnShowCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowCartPage.aspx");
        }
    }
}