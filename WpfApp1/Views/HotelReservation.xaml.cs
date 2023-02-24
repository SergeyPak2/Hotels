using System;
using System.Collections.Generic;
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
using WpfApp1.Models;

namespace WpfApp1.Views
{
    public partial class HotelReservation : UserControl
    {
        public HotelReservation(Hotel hotel)
        {
            InitializeComponent(); 
            DataContext = hotel;
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Hotel hotel = (Hotel)((sender as UserControl).DataContext);
            FrameManager.Frame.Navigate(new HotelReservationData(hotel));
            MainWindow.hotelID = hotel.ID;
            
        }
    }
}
