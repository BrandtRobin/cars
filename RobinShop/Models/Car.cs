using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RobinShop.Models
{
    public class Car
    {
        public long Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}