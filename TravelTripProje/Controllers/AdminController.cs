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
        public ActionResult BlogSil(int id) {
        var b =c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var v=c.Blogs.Find(id);
            return View("BlogGetir",v);
        }
        [HttpGet]
        public ActionResult YorumListesi()
        {
            var d = c.Yorumlar.ToList();
            return View(d);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlar.Find(id);
            c.Yorumlar.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var v = c.Yorumlar.Find(id);
            return View("YorumGetir", v);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var v = c.Yorumlar.Find(y.ID);
            v.KullaniciAdi = y.KullaniciAdi;
            v.Mail = y.Mail;
            v.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

    }
}