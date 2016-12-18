using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IceYaa_ASP.NET.Models
{
    public class TableBook
    {
        public int ID { get; set; }
        public string Floor { get; set; }
        public string TableNo { get; set; }
        public string Status { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateBooking { get; set; }

    }
    public class TableBookDBContext : DbContext
    {
        public DbSet<TableBook> TableBooks { get; set; }
    }
}