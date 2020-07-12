using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using kisiselWeb22.Models;
namespace kisiselWeb22.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index( Login form)
        {
            if (ModelState.IsValid)
            {
                using(kisiselwebEntities db=new kisiselwebEntities())
                {
                    var gelen = db.Logins.Where(m => m.Username.Equals(form.Username) && m.Pass.Equals(form.Pass)).FirstOrDefault();
                    if(gelen != null)
                    {
                        FormsAuthentication.SetAuthCookie(gelen.Username, false);
                        Session["Id"] = gelen.Id.ToString();
                        Session["Username"] = gelen.Username.ToString();
                        return RedirectToAction("Index","Admin");
                    }
                    else
                    {
                        ViewBag.Mesaj = "Kullanici adi veya parola hatali...";
                    }
                }
            }
          
            return View(form);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}