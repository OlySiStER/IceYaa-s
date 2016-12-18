using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IceYaa_ASP.NET.Models
{
    public class Menu
    {
        public int ID { get; set; }

        public string FoodName { get; set; }

        public string FoodType { get; set; }

        public string FoodPrice { get; set; }

    }

    public class MenuDBContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
    }

}