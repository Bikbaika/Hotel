using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class UsedService
    {
        [Key]
        public DateTime Date { get; set; } //дата
        public int Amount { get; set; } //количество раз
        public int TotalAmount { get; set; } //общая стоимость

        public ServiceList ServiceList { get; set; }
        public int ServiceId { get; set; } // ссылка на связанную модель ServiceList

        public Order Order { get; set; }
        public int OrderId { get; set; } // ссылка на связанную модель Order
    }
}
