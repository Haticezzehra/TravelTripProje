using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adress { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkizmida { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Yorumlar> Yorumlar { get; set; }

    }
}