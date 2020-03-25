using Lab4PRN.DAO;
using Lab4PRN.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4PRN.View
{
    public partial class Home : System.Web.UI.Page
    {
        FlightDAO flightDAO = new FlightDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                if (Session["account"] != null)
                {
                    Account account = (Account)Session["account"];
                    String fullname = "Hello " + account.User.Fname;
                    lb_fullname.Text = fullname;
                    tableTicket.DataSource = flightDAO.GetAllFlight();
                    tableTicket.DataBind();
                   

                }
                else
                {
                    Response.Redirect("Entry.aspx");
                }
              
            
            
        }
       
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.Depart_date = calendar_depart.SelectedDate.ToString("yyyy-MM-dd");
            flight.Arrival_date = calendar_arrival.SelectedDate.ToString("yyyy-MM-dd");
            flight.Depart_country = txt_depart_country.Text;
            flight.Arrival_country = txt_arrival_country.Text;
            tableTicket.DataSource = flightDAO.SearchFlight(flight);
            tableTicket.DataBind();
           
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("account");
            Session.Remove("all_ticket");
            Response.Redirect("Entry.aspx");

        }

        protected void linkPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void linkMyTicket_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyTicket.aspx");
        }
    }
}