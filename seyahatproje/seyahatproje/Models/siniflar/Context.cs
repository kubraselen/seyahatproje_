using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace seyahatproje.Models.siniflar
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> Adreses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<otel> Otels { get; set; }
         public DbSet<rezervasyonum> rezervasyonums { get; set; }
        
    
    }
}