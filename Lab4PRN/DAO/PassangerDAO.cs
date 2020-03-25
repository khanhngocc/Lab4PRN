using Lab4PRN.Entity;
using Lab4PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab4PRN.DAO
{
    public class PassangerDAO
    {
        DBContext dBContext = new DBContext();
        public int GetMaxID()
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select MAX(id) from Passanger"
                          
            ;
            SqlCommand command = new SqlCommand(query, cnn);
           
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                num = reader.GetInt32(0);
            }

            cnn.Close();
            return num;
        }
        public void insertPassanger(Passanger passanger)
        {

            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Passanger values(@val1,@val2,@val3,@val4,@val5)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", passanger.Fname);
            command.Parameters.AddWithValue("@val2", passanger.Lname);
            command.Parameters.AddWithValue("@val3", passanger.Dob);
            command.Parameters.AddWithValue("@val4",passanger.Email);
            command.Parameters.AddWithValue("@val5", passanger.Phone);
            command.ExecuteNonQuery();


        }

    }
}