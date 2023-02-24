using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string NumberPhone { get; set; }
        public string DateOfReservation { get; set; }
        public Hotel HotelID { get; set; }

    }
}
