using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace seyahatproje.Models.siniflar
{
    public class rezervasyonum
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set;}
        public string mail { get; set; }
        public string odaturu { get; set; }
        public string odasayisi { get; set; }
        public string Telefon { get; set; }
        public DateTime giristarihi { get; set; }
        public DateTime cikistarihi { get; set; }
        
    }
}