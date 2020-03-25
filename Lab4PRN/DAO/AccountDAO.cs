using Lab4PRN.Entity;
using Lab4PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab4PRN.DAO
{
    public class AccountDAO
    {
        DBContext dBContext = new DBContext();


 

        public void insertAccount(int passanger_id,Account account)
        {

            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Insert into Account values(@val1,@val2,@val3)";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", account.Username);
            command.Parameters.AddWithValue("@val2", account.Password);
            command.Parameters.AddWithValue("@val3", passanger_id);
            command.ExecuteNonQuery();


        }


        public bool IsExistedAccount(Account account)
        {
           
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select * from Account"
                         +" where username = @val1"
                         +" and"
                         +" password = @val2"
            ;

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1",account.Username);
            command.Parameters.AddWithValue("@val2",account.Password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }

            cnn.Close();
            return false;
        }

        public int GetIdOfUser(Account account)
        {
            int id = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select passanger_id from Account"
                         + " where username = @val1"
                         + " and"
                         + " password = @val2"
            ;

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", account.Username);
            command.Parameters.AddWithValue("@val2", account.Password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            cnn.Close();
            return id;
        }
        public int GetIdOfAccount(Account account)
        {
            int id = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Account.id from Account"
                         + " where username = @val1"
                         + " and"
                         + " password = @val2"
            ;

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", account.Username);
            command.Parameters.AddWithValue("@val2", account.Password);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            cnn.Close();
            return id;
        }
        public Passanger GetPassanger(int passanger_id)
        {
            Passanger passanger = new Passanger();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Passanger.lname,Passanger.fname from Account,Passanger"
                          +" where Account.passanger_id = Passanger.id"
                          +" and"
                          +" Passanger.id = @val1"
            ;

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", passanger_id);
           
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                passanger.Lname = reader.GetString(0);
                passanger.Fname = reader.GetString(1);
            }

            cnn.Close();
            return passanger;
        }
    }
}