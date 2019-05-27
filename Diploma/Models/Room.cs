using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class Room
    {
        public int Id { get; set; } // Номер комнаты
        public string Location { get; set; } //Расположение

        public Service Service { get; set; }
        public string TypeOfRoom { get; set; } // ссылка на связанную модель Service
    }
}
