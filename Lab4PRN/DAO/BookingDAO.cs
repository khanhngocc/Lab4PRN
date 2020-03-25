using Lab4PRN.Entity;
using Lab4PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab4PRN.DAO
{
    public class BookingDAO
    {
        DBContext dBContext = new DBContext();

        public void insertBooking(int account_id,int flight_id,String date)
        {
          
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Booking values(@val1,@val2,@val3)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1",account_id);
            command.Parameters.AddWithValue("@val2", flight_id);
            command.Parameters.AddWithValue("@val3",date);
            command.ExecuteNonQuery();
          

        }

      

        public void insertFeedback(String message,String date,int account_id)
        {

            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Inbox values(@val1,@val2,@val3)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", message);
            command.Parameters.AddWithValue("@val2", date);
            command.Parameters.AddWithValue("@val3", account_id);
            command.ExecuteNonQuery();


        }
    }
}