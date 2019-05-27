using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class Order
    {
        public int OrderId { get; set; } //Номер заказа
        public DateTime OrderDate { get; set; } //Дата заказа
        public DateTime BookingFrom { get; set; } //Дата прибытия
        public DateTime BookingTo { get; set; } // Дата выезда
        public int OrderCost { get; set; } // стоимость

        public int ClientId { get; set; } // ссылка на связанную модель Client
        public Client Client { get; set; }

        public int RoomId { get; set; } // ссылка на связанную модель Room
        public Room Room { get; set; }

    }
}
