using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Views;
using WpfApp1.Models;
using MySql.Data.MySqlClient;
using WpfApp1.Database;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public static ObservableCollection<HotelReservation> hotelReservations = new ObservableCollection<HotelReservation>();   
        public static ObservableCollection<Hotel> hotels = new ObservableCollection<Hotel>();
        public static DatabaseQuery query = new DatabaseQuery();
        public static int hotelID;

        public MainWindow()
        {
            InitializeComponent();
            FrameManager.Frame = hotelsDataFrame;
            GetHotels();
            reservationHotelsListView.ItemsSource = hotelReservations;                 
        }

        public void GetHotels()
        {
            hotels = query.SelectHotels("SELECT * FROM Hotel");
            foreach (var hotel in hotels)
            {
                hotelReservations.Add(new HotelReservation(hotel));
              
            }
        }

        private void reservateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(phoneNumberBox.Text))
            {
                query.UpdateReservation(phoneNumberBox.Text, hotelID);
            }
            MessageBox.Show("Успешно!", "УСПЕХ!");
        }
    }
}
