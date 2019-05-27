using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class Service
    {
        [Key]
        public string RoomType { get; set; } //Вид номера
        public int Price { get; set; } //Стоимость номера
        public string ServiceFrequency { get; set; } //Периодичность обслуживания
    }
}
