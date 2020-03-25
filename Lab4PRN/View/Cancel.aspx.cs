using Lab4PRN.DAO;
using Lab4PRN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4PRN.View
{
    public partial class Cancel : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            int flight_id = Int32.Parse(Request.QueryString["fid"].ToString());
            List<int> list_temp = (List<int>)Session["all_ticket"];
            list_temp.Remove(flight_id);
            Label1.Text = "Cancel successfully";

        }

        protected void linkPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}