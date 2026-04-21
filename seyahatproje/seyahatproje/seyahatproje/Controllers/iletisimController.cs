using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatproje.Models.siniflar;
namespace seyahatproje.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }
       [HttpGet]
        public PartialViewResult gonder()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult gonder(iletisim y)
        {
            c.iletisims.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}