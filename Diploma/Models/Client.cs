using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class Client
    {
        public int Id { get; set; } // Номер клиента
        public string Name { get; set; } // ФИО
        public int PassportId { get; set; } // Номер паспорта
        public int PassportSer { get; set; } // Серия паспорта
        public string Address { get; set; } // Адрес
        public string CitizenShip { get; set; } // Гражданство
    }
}
