using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatproje.Models.siniflar;
namespace seyahatproje.Controllers
{
    public class otelController : Controller
    {
        // GET: otel

        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Otels.ToList();
            return View(degerler);
        }
        [HttpGet]
        public PartialViewResult otel1()
        {
            var degerler = c.Otels.OrderByDescending(x => x.id).Take(6).ToList();
            return PartialView(degerler);
        }
         public PartialViewResult otel2()
        {
            var deger = c.Otels.Where(x => x.id == 0).ToList();
            return PartialView(deger);
        }
       public ActionResult rezervasyon()
        {

            var degeri = c.rezervasyonums.ToList();
            return View(degeri);

        }

        public ActionResult rezervasyonyapp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult rezervasyonyapp(rezervasyonum p)
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

        public ActionResult rezervasyongetir(int ID)
        {
            var bl = c.rezervasyonums.Find(ID);
            return View("rezervasyongetir", bl);
        }
        public ActionResult rezervasyonguncelle(rezervasyonum b)
        {
            var blg = c.rezervasyonums.Find(b.id);
            blg.Ad = b.Ad;
            blg.Soyad = b.Soyad;
            blg.mail = b.mail;
            blg.odaturu = b.odaturu;
            blg.odasayisi = b.odasayisi;
            blg.Telefon = b.Telefon;
            blg.giristarihi = b.giristarihi;
            blg.cikistarihi = b.cikistarihi;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        /*[HttpGet]
        public PartialViewResult rezervasyonyap()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult rezervasyonyap(rezervasyonum y)
        {
            c.rezervasyonums.Add(y);
            c.SaveChanges();
            return PartialView();
        }*/

    }

}




