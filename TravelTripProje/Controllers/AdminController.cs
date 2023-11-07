using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        //Kaydetme Sayfamızı açtığımız zaman açılacak sayfaya yönlendirme
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        //Kaydetme işlemi yapacağımız zaman kullanırız
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}