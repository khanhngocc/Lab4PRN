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
        static int pageCount;
        static int pageIndex = 1;
        int pageSize = 5;
        static bool isAll = true;
        
        public void LoadPageNumber()
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= pageCount; i++)
                   list.Add(i);

            pageNumberList.DataSource = list;
            pageNumberList.DataBind();
        }


        public void RefreshPage()
        {
          
            txt_arrival_country.Text = "";
            txt_depart_country.Text = "";
            isAll = true;
            pageIndex = 1;
            loadData();
         
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
               
                if (Session["account"] != null)
                {
                    Account account = (Account)Session["account"];
                    String fullname = "Hello " + account.User.Fname;
                    lb_fullname.Text = fullname;
                    isAll = true;
                    loadData();
                    
                 }
                else
                {
                    Response.Redirect("Entry.aspx");
                }
            }
            
        }
       
        public void loadData()
        {
            tableTicket.DataSource = null;
            tableTicket.DataSource = flightDAO.GetAllFlight(pageIndex, pageSize);
            tableTicket.DataBind();
            int rowCount = flightDAO.GetRowCountAllFlight();
            caculatePageCount(rowCount);
            LoadPageNumber();
        }

        public void caculatePageCount(int rowCount)
        {

            if (rowCount % pageSize == 0)
            {
                pageCount = rowCount / pageSize;
            }
            else
            {
                pageCount = rowCount / pageSize + 1;
            }
        }

        public void loadDataFilter()
        {
            Flight flight = new Flight();
            flight.Depart_date = calendar_depart.SelectedDate.ToString("yyyy-MM-dd");
            flight.Arrival_date = calendar_arrival.SelectedDate.ToString("yyyy-MM-dd");
            flight.Depart_country = txt_depart_country.Text;
            flight.Arrival_country = txt_arrival_country.Text;
            tableTicket.DataSource = null;
            tableTicket.DataSource = flightDAO.SearchFlight(flight,pageIndex,pageSize);
            tableTicket.DataBind();
            int rowCount = flightDAO.GetRowCountFilterFlight(flight);
            caculatePageCount(rowCount);
            LoadPageNumber();
            
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
           if(isAll == true)
            {
                isAll = false;
               
            }
            pageIndex = 1;
            loadDataFilter();
           
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

        protected void pageNumberList_SelectedIndexChanged(object sender, EventArgs e)
        {

            pageIndex = Int32.Parse(pageNumberList.SelectedValue);

            if (isAll == true)
            {
                
                loadData();
            }
            else
            {
                loadDataFilter();
            }

            pageNumberList.SelectedValue = pageIndex + "";

        }

        protected void LinkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void LinkHome_Click1(object sender, EventArgs e)
        {
            RefreshPage();
        }

        protected void linkMyTicket_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MyTicket.aspx");
        }
    }
}