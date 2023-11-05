using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{

    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }


        public PartialViewResult Partial1()
        {
            var deger = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();

            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(X => X.ID == 9).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public ActionResult Contact()
        {


            return View();
        }
    }
}