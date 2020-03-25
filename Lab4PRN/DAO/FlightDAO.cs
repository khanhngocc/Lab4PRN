using Lab4PRN.Entity;
using Lab4PRN.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab4PRN.DAO
{
    public class FlightDAO
    {
        DBContext dBContext = new DBContext();

        public int GetRowCountFilterFlight(Flight flight)
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Count(*) from Flight,Airplane,Owner_Flight"
                          + " where"
                          + " Flight.id = Owner_Flight.flight_id"
                          + " and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                          + " Flight.id not in (Select Booking.flight_id from Booking)"
                          + " and"
                          + " depart_date = @val1"
                          + " and"
                          + " arrival_date = @val2"
                          + " and"
                          + " depart_country = @val3"
                          + " and"
                          + " arrival_country = @val4"
            ;
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", flight.Depart_date);
            command.Parameters.AddWithValue("@val2", flight.Arrival_date);
            command.Parameters.AddWithValue("@val3", flight.Depart_country);
            command.Parameters.AddWithValue("@val4", flight.Arrival_country);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                num = reader.GetInt32(0);
            }

            cnn.Close();
            return num;
        }


        public List<Flight> SearchFlight(Flight flight, int pageIndex, int pageSize)
        {
            int indexOfFirstRecord = (pageIndex - 1) * pageSize;
            List<Flight> flights = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Airplane,Owner_Flight"
                          + " where"
                          + " Flight.id = Owner_Flight.flight_id"
                          + " and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                          + " Flight.id not in (Select Booking.flight_id from Booking)"
                          + " and"
                          + " depart_date = @val1"
                          + " and"
                          + " arrival_date = @val2"
                          + " and"
                          + " depart_country = @val3"
                          + " and"
                          + " arrival_country = @val4"
                          + " Order by Flight.id"
                          + " OFFSET @val5 ROW"
                          + " FETCH NEXT @val6 ROW ONLY";
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", flight.Depart_date);
            command.Parameters.AddWithValue("@val2", flight.Arrival_date);
            command.Parameters.AddWithValue("@val3", flight.Depart_country);
            command.Parameters.AddWithValue("@val4", flight.Arrival_country);
            command.Parameters.AddWithValue("@val5",indexOfFirstRecord);
            command.Parameters.AddWithValue("@val6",pageSize);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Flight_name = reader.GetString(11);
                temp.Airway_station = reader.GetString(12);
                temp.Airplane_name = reader.GetString(13);
                flights.Add(temp);
            }
            cnn.Close();
            return flights;

        }

        public int GetRowCountAllFlight()
        {
            int num = 0;
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Count(*) from Flight,Airplane,Owner_Flight"
                          + " where"
                          + " Flight.id = Owner_Flight.flight_id"
                          + " and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                          + " Flight.id not in (Select Booking.flight_id from Booking)"
                         
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

        public List<Flight> GetAllFlight(int pageIndex, int pageSize)
        {
            int indexOfFirstRecord = (pageIndex - 1) * pageSize;
            List<Flight> flights = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Airplane,Owner_Flight"
                          + " where"
                          + " Flight.id = Owner_Flight.flight_id"
                          + " and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                          + " Flight.id not in (Select Booking.flight_id from Booking)"
                          + " Order by Flight.id"
                          + " OFFSET @val1 ROW"
                          + " FETCH NEXT @val2 ROW ONLY"
                          ;
                        
            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1",indexOfFirstRecord);
            command.Parameters.AddWithValue("@val2",pageSize);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Flight_name = reader.GetString(11);
                temp.Airway_station = reader.GetString(12);
                temp.Airplane_name = reader.GetString(13);
                flights.Add(temp);
            }
            cnn.Close();
            return flights;
            
        }

        public List<Flight> GetAllFlightBookedOfUser(int account_id)
        {
            List<Flight> flights = new List<Flight>();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name,Booking.date_time from Booking,Flight,Airplane,Owner_Flight"
                           +" where"
                           +" Booking.flight_id = Flight.id"
                           +" and"
                           +" Owner_Flight.airplane_id = Airplane.id"
                           +" and"
                           +" Owner_Flight.flight_id = Flight.id"
                           +" and"
                           +" account_id = @val1"
                          ;

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1", account_id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Flight temp = new Flight();
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Flight_name = reader.GetString(11);
                temp.Airway_station = reader.GetString(12);
                temp.Airplane_name = reader.GetString(13);
                temp.DateTime_booked = reader.GetDateTime(14);
                flights.Add(temp);
            }
            cnn.Close();
            return flights;

        }


        public Flight GetFlightByID(int id)
        {
            Flight temp = new Flight();
            SqlConnection cnn = dBContext.GetConnection();
            cnn.Open();
            String query = "Select Flight.*,Airplane.name from Flight,Airplane,Owner_Flight"
                          + " where"
                          + " Flight.id = Owner_Flight.flight_id"
                          + " and"
                          + " Airplane.id = Owner_Flight.airplane_id"
                          + " and"
                          + " Flight.id = @val1";

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@val1",id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                
                temp.Id = reader.GetInt32(0);
                temp.Depart_time = reader.GetString(1);
                temp.Depart_date = reader.GetString(2);
                temp.Arrival_time = reader.GetString(3);
                temp.Arrival_date = reader.GetString(4);
                temp.Depart_country = reader.GetString(5);
                temp.Arrival_country = reader.GetString(6);
                temp.Direction = reader.GetString(7);
                temp.Type = reader.GetString(8);
                temp.Price = reader.GetDouble(9);
                temp.No_seat = reader.GetInt32(10);
                temp.Flight_name = reader.GetString(11);
                temp.Airway_station = reader.GetString(12);
                temp.Airplane_name = reader.GetString(13);

            }
            cnn.Close();
            return temp;

        }
    }
}