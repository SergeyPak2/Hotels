using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using WpfApp1.Models;

namespace WpfApp1.Database
{
    public class DatabaseQuery
    {
        public ObservableCollection<Hotel> SelectHotels(string query)
        {
            ObservableCollection<Hotel> hotels = new ObservableCollection<Hotel>();
            MySqlConnection mySqlConnection = new MySqlConnection("Server = 127.0.0.1; Port=3306; Database=reservationhotelsdatabase; Uid=root");
            mySqlConnection.Open();           
            MySqlCommand command = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                hotels.Add(new Hotel()
                {
                    ID = Convert.ToInt32(reader[0]),
                    Title = Convert.ToString(reader[1]),
                    CountOfStars = Convert.ToInt32(reader[2]),
                    Address = Convert.ToString(reader[3])
                });              
            }
            reader.Close();
            mySqlConnection.Close();
            return hotels;  
        }
        public void UpdateReservation(string phoneNumber, int hotelID)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server = 127.0.0.1; Port=3306; Database=reservationhotelsdatabase; Uid=root");
            mySqlConnection.Open();
            MySqlCommand command = new MySqlCommand($"UPDATE Rservation SET HotelID = '{hotelID}' WHERE NumberPhone = '{phoneNumber}'", mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();            
            reader.Close();
            mySqlConnection.Close();
        }
    }
      
    
}

