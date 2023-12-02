using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin a)
        {
            var bilgiler = c.Admins.FirstOrDefault(c => c.Kullanici == a.Kullanici & c.Sifre == a.Sifre);
            if(bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();//Sessiona değer gönderdik.
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
           
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }

    }
}