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
    public partial class SignIn : System.Web.UI.Page
    {
        PassangerDAO passangerDAO = new PassangerDAO();
        AccountDAO accountDAO = new AccountDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            calendar.TodaysDate = new DateTime(1999, 12, 01);
        }

        protected void linkEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("Entry.aspx");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Passanger passanger = new Passanger();
            passanger.Fname = txt_fname.Text;
            passanger.Lname = txt_lname.Text;
            passanger.Dob = calendar.SelectedDate.ToString("yyyy-MM-dd");
            passanger.Email = txt_email.Text;
            passanger.Phone = Int32.Parse(txt_phone.Text);
            passangerDAO.insertPassanger(passanger);
            Account account = new Account();
            account.Username = txt_user.Text;
            account.Password = txt_pass.Text;
            int max_id = passangerDAO.GetMaxID();
            accountDAO.insertAccount(max_id, account);
            lb_message.Text = "Successfully";
        }
    }
}