using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diploma.Models
{
    public class HotelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
