using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatproje.Models.siniflar;

namespace seyahatproje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
           var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

       public ActionResult rezervasyonum()
        {
            var degeri = c.rezervasyonums.ToList();
            return View(degeri);
        }
         public ActionResult yenirezervasyonum()
        {
            return View();
        }
         [HttpPost]
         public ActionResult yenirezervasyonum(rezervasyonum p)
         {
             c.rezervasyonums.Add(p);
             c.SaveChanges();
             return RedirectToAction("Index");
         }
         public ActionResult rezervasyonsil(int id)
         {
             var b = c.rezervasyonums.Find(id);
             c.rezervasyonums.Remove(b);
             c.SaveChanges();
             return RedirectToAction("Index");

         }
        public ActionResult rezervasyongetir(int id)
         {
             var rv = c.rezervasyonums.Find(id);
             return View("rezervasyongetir", rv);
         }

       public ActionResult rezervasyonguncelle(rezervasyonum r)
         {
             var rzv = c.rezervasyonums.Find(r.id);
             rzv.Ad = r.Ad;
             rzv.Soyad = r.Soyad;
             rzv.mail = r.mail;
             rzv.odaturu = r.odaturu;
             rzv.odasayisi = r.odasayisi;
             rzv.Telefon = r.Telefon;
             rzv.giristarihi = r.giristarihi;
             rzv.cikistarihi = r.cikistarihi;
             c.SaveChanges();
             return RedirectToAction("Index");
        }
    }
}
