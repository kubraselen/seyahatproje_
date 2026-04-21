using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace seyahatproje.Models.siniflar
{
    public class otel
    {
        [Key]
        public int id { get; set; }
        public string yataksayisi { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
        public string odaadi { get; set; }
        public string ucret { get; set; }

        }

    }
