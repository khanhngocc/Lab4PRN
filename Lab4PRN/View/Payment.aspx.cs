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
    public partial class Payment : System.Web.UI.Page
    {
        FlightDAO flightDAO = new FlightDAO();
        List<Flight> flights_booked = new List<Flight>();
        BookingDAO bookingDAO = new BookingDAO();
        
        public bool IsExisted(int id)
        {
            foreach(Flight f in flights_booked)
            {
                if (f.Id == id)
                    return true;
            }

            return false;
        }
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["account"] != null)
            {

                if (Session["all_ticket"] != null)
                {
                   
                    List<int> list_temp = (List<int>)Session["all_ticket"];

                    if (list_temp.Count == 0)
                    {
                        lb_message.Text = "You have no flight to pay";
                        btnPay.Enabled = false;
                        txt_feed_back.Enabled = false;
                    }
                    else
                    {
                        btnPay.Enabled = true;
                        txt_feed_back.Enabled = true;
                        lb_message.Text = "Your flight in wait list";
                        double total_money = 0;
                        foreach (int a in list_temp)
                        {
                            if (IsExisted(a) == false)
                            {
                                Flight temp = flightDAO.GetFlightByID(a);
                                flights_booked.Add(temp);
                                total_money += temp.Price;
                            }

                        }

                        gridFlightBooked.DataSource = flights_booked;
                        gridFlightBooked.DataBind();
                        lb_total_money.Text = "Total money: " + total_money + "$";
                    }


                   
                    
                }
                else
                {
                   
                        lb_message.Text = "You have no flight in wait list to pay";
                        btnPay.Enabled = false;
                        txt_feed_back.Enabled = false;
                    
                   
                }

            }
            else
            {
                Response.Redirect("Entry.aspx");
            }
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            Account account = (Account)Session["account"];
            String datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            foreach(Flight f in flights_booked)
            {
                bookingDAO.insertBooking(account.Id, f.Id, datetime);
            }

            String feed_back = txt_feed_back.Text;

            if(feed_back.Length != 0)
            {
                bookingDAO.insertFeedback(feed_back, datetime, account.Id);
            }

            Session.Remove("all_ticket");
            lb_successfully.Text = "Paying successfully!";
            
        }

        protected void homePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}