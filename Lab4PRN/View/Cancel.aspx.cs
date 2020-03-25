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
        BookingDAO bookingDAO = new BookingDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Account account = (Account)Session["account"];
            int flight_id = Int32.Parse(Request.QueryString["fid"].ToString());
            bookingDAO.deleteBooking(account.Id,flight_id);
            Label1.Text = "Cancel successfully";

        }

        protected void linkMyTicket_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyTicket.aspx");
        }
    }
}