using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class ServiceList
    {
        public int Id { get; set; } //Номер услуги
        public string Name { get; set; } //Наименование
        public int Price { get; set; } //Стоимость
        public string Units { get; set; } //единицы измерения
    }
}
