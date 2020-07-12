using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kisiselWeb22.Models;

namespace kisiselWeb22.Controllers
{
    public class HomeController : Controller
    {
        kisiselwebEntities db = new kisiselwebEntities();
        // GET: Home
        public ActionResult Index()
        {
            var deger = db.Database.SqlQuery<KullaniciBilgi>("select top 1 *from KullaniciBilgi order by id desc").ToList();
            //var deger = db.KullaniciBilgis.ToList();
            return View(deger);
        }

        public ActionResult OzGecmis()
        {
            //sadece yetenekler kaldi
            return View();
        }
        public PartialViewResult Egitim()
        {
            var deger = db.Database.SqlQuery<EgitimOZ>("select top 4 * from EgitimOz order by Id asc").ToList();
            return PartialView(deger);
        }
        public PartialViewResult Deneyim()
        {
            var deger = db.Database.SqlQuery<DeneyimOZ>("select top 5 * from DeneyimOz order by id asc").ToList();
            return PartialView(deger);
        }
        public PartialViewResult Yetenek()
        {
            return PartialView();
        }

        public PartialViewResult Odul()
        {
            var deger = db.Database.SqlQuery<OdullOZ>("select top 4 * from OdullOZ order by id asc").ToList();
            return PartialView(deger);
        }
        public ActionResult Servis()
        {
            var deger = db.Database.SqlQuery<Servi>("select top 6 * from Servis order by id asc").ToList();
            return View(deger);
        }

        public ActionResult Proje()
        {
            var deger = db.Database.SqlQuery<Project>("select top 6 *from Project order by id asc").ToList();
            return View(deger);
        }

        public ActionResult Blog()
        {
            var deger = db.Database.SqlQuery<Blog>("select top 3 *from Blog order by id asc").ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult Iletisim()
        {
            var deger = db.Iletisims.ToList();
            return View(deger);
        }
        [HttpPost]
        public ActionResult Iletisim(FormCollection form)
        {
            Iletisim bilgi = new Iletisim();
            bilgi.Ad = form["name"].Trim();
            bilgi.Email = form["email"].Trim();
            bilgi.KonuBaslik = form["konu"].Trim();
            bilgi.Messaj = form["messaj"].Trim();

            db.Iletisims.Add(bilgi);
            db.SaveChanges();

            return View();
        }
        public PartialViewResult IletisimBilgiler()
        {
            var deger = db.Database.SqlQuery<KullaniciBilgi>("select top 1 *from KullaniciBilgi order by id asc").ToList();
            return PartialView(deger);
        }
    }
}