using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IceYaa.Models
{
    public class Table
    {
        public int ID { get; set; }
        public string Floor { get; set; }
        public string TableNo { get; set; }
        public string Status { get; set; }
    }
    public class TableDBContext : DbContext
    {
        public DbSet<Table> Tables { get; set; }
    }
}