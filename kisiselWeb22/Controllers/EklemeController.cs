using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kisiselWeb22.Models;
namespace kisiselWeb22.Controllers
{
    [Authorize]
    public class EklemeController : Controller
    {
        kisiselwebEntities db = new kisiselwebEntities();
        // GET: Ekleme
        [HttpGet]
        public ActionResult Index()
        {
            //var bilgi = db.KullaniciBilgis.ToList();
            return View();

        }
        [HttpPost]
        public ActionResult Index( KullaniciBilgi form)
        {
            //KullaniciBilgi gelen = new KullaniciBilgi();
            if (ModelState.IsValid)
            {

               
                db.KullaniciBilgis.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(form);
            }
            
        }
        [HttpGet]
        public ActionResult ServisEkle()
        {
            //var deger = db.Servis.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ServisEkle(Servi form)
        {
            if (ModelState.IsValid)
            {
                db.Servis.Add(form);
                db.SaveChanges();

                return RedirectToAction("ServisEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult GalEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult GalEkle(Galeri form)
        {
            Galeri gelen = new Galeri();
            if (ModelState.IsValid)
            {            
                db.Galeris.Add(form);
                db.SaveChanges();
                return RedirectToAction("GalEkle");
            }
            return View(form);
        }

        [HttpGet]
        public ActionResult ProjeEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ProjeEkle(Project form)
        {
            
            if (ModelState.IsValid)
            {
                db.Projects.Add(form);
                db.SaveChanges();
                return RedirectToAction("ProjeEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult SosEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult SosEkle(SosyalHesap form)
        {

            if (ModelState.IsValid)
            {
                db.SosyalHesaps.Add(form);
                db.SaveChanges();
                return RedirectToAction("SosEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult IletisimEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult IletisimEkle(Iletisim form)
        {

            if (ModelState.IsValid)
            {
                db.Iletisims.Add(form);
                db.SaveChanges();
                return RedirectToAction("IletisimEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult BlogEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult BlogEkle(Blog form)
        {

            if (ModelState.IsValid)
            {
                db.Blogs.Add(form);
                db.SaveChanges();
                return RedirectToAction("BlogEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult BeceriEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult BeceriEkle(BeceriOZ form)
        {

            if (ModelState.IsValid)
            {
                db.BeceriOZs.Add(form);
                db.SaveChanges();
                return RedirectToAction("BeceriEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(DeneyimOZ form)
        {

            if (ModelState.IsValid)
            {
                db.DeneyimOZs.Add(form);
                db.SaveChanges();
                return RedirectToAction("DeneyimEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(EgitimOZ form)
        {

            if (ModelState.IsValid)
            {
                db.EgitimOZs.Add(form);
                db.SaveChanges();
                return RedirectToAction("EgitimEkle");
            }
            return View(form);
        }
        [HttpGet]
        public ActionResult OdulEkle()
        {
            //var deger = db.Galeris.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult OdulEkle(OdullOZ form)
        {

            if (ModelState.IsValid)
            {
                db.OdullOZs.Add(form);
                db.SaveChanges();
                return RedirectToAction("OdulEkle");
            }
            return View(form);
        }

    }
}