using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace seyahatproje.Models.siniflar
{
    public class Rezervasyon
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string odaturu { get; set; }
        public string odasayisi { get; set; }
        public string misafirsayisi { get; set; }
        public string cocuksayisi { get; set; }
        public DateTime Giris_cikis_tarihi { get; set; }
       
    }
}