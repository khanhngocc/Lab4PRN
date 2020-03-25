using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4PRN.View
{
    public partial class details : System.Web.UI.Page
    {
        

        public bool IsExistedID(int id, List<int> list)
        {
            foreach(int a in list)
            {
                if (a == id)
                    return true;
            }

            return false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
          
                int current_id = Int32.Parse(Request.QueryString["fid"].ToString());
                List<int> list_temp = (List<int>) Session["all_ticket"];

                if(list_temp == null)
                {
                    List<int> IDTicketBook = new List<int>();
                    IDTicketBook.Add(current_id);
                    Session["all_ticket"] = IDTicketBook;
                    Label1.Text = "Book flight successfully!";
                    Label2.Text = "Total ticket you have book: "+ IDTicketBook.Count + "";
                }
                else
                {
                    if (IsExistedID(current_id, list_temp))
                    {
                        Label1.Text = "You have booked flight " + Request.QueryString["fname"].ToString() + " of " + Request.QueryString["aname"].ToString();
                    }
                    else
                    {
                        list_temp.Add(current_id);
                        Session["all_ticket"] = list_temp;
                        Label1.Text = "Book flight successfully!";
                    }

                    Label2.Text = "Total ticket you have book: "+list_temp.Count + "";
            }

                
                
        }
    }
}