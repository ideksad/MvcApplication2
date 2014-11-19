using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcApplication2.Models
{
    public class Song
    
   {
       public int ID { get; set; }
       public string Title { get; set; }
       public DateTime ReleaseDate { get; set; }
       public string Genre { get; set; }
       public decimal Price { get; set; }
   }

    public class SongDBContext : DbContext
    {



        public DbSet<Song> Songs { get; set; }
    }
}