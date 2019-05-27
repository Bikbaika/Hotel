using Diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma
{
    public class SampleData
    {
        public static void Initialize(HotelContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        Name = "Евсеева Валерия Владимировна",
                        PassportId = 145287,
                        PassportSer = 0914,
                        Address = "г. Севастополь, ул. Кожанова д.2",
                        CitizenShip = "РФ",
                    },
                    new Client
                    {
                        Name = "Олейников Дмитрий Юрьевич",
                        PassportId = 542874,
                        PassportSer = 0914,
                        Address = "г. Севастополь, ул. Авдеева д.32",
                        CitizenShip = "РФ",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
