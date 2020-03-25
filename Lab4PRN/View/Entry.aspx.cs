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
    public partial class Entry : System.Web.UI.Page
    {
        AccountDAO accountDAO = new AccountDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtuser.Text;
            String password = txtpass.Text;
            Account account = new Account();
            account.Username = username;
            account.Password = password;

            if (accountDAO.IsExistedAccount(account))
            {
                account.Id = accountDAO.GetIdOfAccount(account);
                int id_user = accountDAO.GetIdOfUser(account);
                account.User = accountDAO.GetPassanger(id_user);
                Session["account"] = account;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lb_message.Text = "Login Fail";
            }
        }
    }
}