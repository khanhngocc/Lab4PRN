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
    public partial class MyTicket : System.Web.UI.Page
    {
        FlightDAO flightDAO = new FlightDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["account"] != null)
                {

                   
                        lb_message.Text = "Your flight you booked";
                        Account account = (Account)Session["account"];
                        gridViewTicketBooked.DataSource = flightDAO.GetAllFlightBookedOfUser(account.Id);
                        gridViewTicketBooked.DataBind();
                    

                }
                else
                {
                    Response.Redirect("Entry.aspx");
                }
            }
        }

        protected void homePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}