using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Lab4PRN.Model
{
    public class DBContext
    {
        SqlConnection connection;
        public SqlConnection GetConnection()
        {

            String connect_text = WebConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
            connection = new SqlConnection(connect_text);
            return connection;
        }
    }
}