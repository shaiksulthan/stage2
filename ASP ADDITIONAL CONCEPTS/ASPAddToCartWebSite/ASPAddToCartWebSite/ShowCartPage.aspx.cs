using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ASPAddToCartWebSite
{
    public partial class ShowCartPage : System.Web.UI.Page
    {
        static int tot_Qty, tot_Amt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AddToCart"]!=null)
            {
                GridView1.DataSource = Session["AddToCart"] as DataTable;
                GridView1.DataBind();
                foreach (GridViewRow drow in GridView1.Rows)
                {
                    tot_Qty = tot_Qty + Convert.ToInt32(drow.Cells[5].Text.Trim());
                    tot_Amt = tot_Amt + Convert.ToInt32(drow.Cells[6].Text.Trim());


                }
                lblTotQty.Text = tot_Qty.ToString();
                lblTotAmt.Text = tot_Amt.ToString();


            }

        }
    }
}