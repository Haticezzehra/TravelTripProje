using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        public ActionResult BlogDetay(int id)
        {
            BlogYorum blogYorum = new BlogYorum();
            blogYorum.Blog = c.Blogs.Where(x => x.ID == id).ToList();
            //ID değerine göre descending olarak sıralama
            blogYorum.Son3Blog=c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList(); 
            blogYorum.Yorum = c.Yorumlar.Where(x => x.BlogID == id);
            return View(blogYorum);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blog = c.Blogs.Find(b.ID);
            blog.Aciklama=b.Aciklama;
            blog.Baslik = b.Baslik;
            blog.BlogImage= b.BlogImage;
            blog.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorum)
        {
            c.Yorumlar.Add(yorum);
            c.SaveChanges();
            return PartialView("Index");
        }
    }
}