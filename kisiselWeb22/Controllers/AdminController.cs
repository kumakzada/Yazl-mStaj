
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kisiselWeb22.Models;
namespace kisiselWeb22.ControllersAdmin
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Home
        kisiselwebEntities db = new kisiselwebEntities();
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult KulBilgiler()
        {
            var deger = db.KullaniciBilgis.ToList();
            return View(deger);
        }
        public ActionResult KulSil(int id)
        {
            var deger = db.KullaniciBilgis.Find(id);
            db.KullaniciBilgis.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("KulBilgiler");
        }
        [HttpGet]
        public ActionResult KulGuncelle(int id)
        {
          
            return View(db.KullaniciBilgis.Where(m=>m.Id==id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult KulGuncelle( int id ,KullaniciBilgi form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("KulBilgiler");
            }
            catch
            {
                return View();
            }
        }
      



        public ActionResult Iletisim()
        {
            var deger = db.Iletisims.ToList();
            return View(deger);
        }

        public ActionResult IletisimSil(int id)
        {
            var deger = db.Iletisims.Find(id);
            db.Iletisims.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Iletisim");
        }
        [HttpGet]
        public ActionResult IletisimGuncelle(int id)
        {

            return View(db.Iletisims.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult IletisimGuncelle(int id, Iletisim form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Iletisim");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Servis()
        {
            var deger = db.Servis.ToList();
            return View(deger);
        }

        public ActionResult ServisSil(int id)
        {
            var deger = db.Servis.Find(id);
            db.Servis.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Servis");
        }
        [HttpGet]
        public ActionResult ServisGuncelle(int id)
        {

            return View(db.Servis.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult ServisGuncelle(int id, Servi form)
        {
            try
            {
                //var ser = db.Servis.Find(form.Id);
                //ser.Id = form.Id;
                //ser.Ad = form.Ad;
                //ser.ResimYol = form.ResimYol;
                //ser.KisaAciklama = form.KisaAciklama;
                //ser.UzunAciklama = form.UzunAciklama;
                 db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Servis");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Proje()
        {
            var deger = db.Projects.ToList();
            return View(deger);
        }
        public ActionResult ProjeSil(int id)
        {
            var deger = db.Projects.Find(id);
            db.Projects.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Proje");
        }
        [HttpGet]
        public ActionResult ProjeGuncelle(int id)
        {

            return View(db.Projects.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult ProjeGuncelle(int id, Project form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Proje");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Blog()
        {
            var deger = db.Blogs.ToList();
            return View(deger);
        }
        public ActionResult BlogSil(int id)
        {
            var deger = db.Blogs.Find(id);
            db.Blogs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Blog");
        }
        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {

            return View(db.Blogs.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult BlogGuncelle(int id, Blog form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Blog");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Egitim()
        {
            var deger = db.EgitimOZs.ToList();
            return View(deger);
        }
        public ActionResult EgitimSil(int id)
        {
            var deger = db.EgitimOZs.Find(id);
            db.EgitimOZs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Egitim");
        }
        [HttpGet]
        public ActionResult EgitimGuncelle(int id)
        {

            return View(db.EgitimOZs.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult EgitimGuncelle(int id, EgitimOZ form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Egitim");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Deneyim()
        {
            var deger = db.DeneyimOZs.ToList();
            return View(deger);
        }
        public ActionResult DeneyimSil(int id)
        {
            var deger = db.DeneyimOZs.Find(id);
            db.DeneyimOZs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Deneyim");
        }
        [HttpGet]
        public ActionResult DeneyimGuncelle(int id)
        {

            return View(db.DeneyimOZs.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult DeneyimGuncelle(int id, DeneyimOZ form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Deneyim");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Beceri()
        {
            var deger = db.BeceriOZs.ToList();
            return View(deger);
        }
        public ActionResult BeceriSil(int id)
        {
            var deger = db.BeceriOZs.Find(id);
            db.BeceriOZs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Beceri");
        }
        [HttpGet]
        public ActionResult BeceriGuncelle(int id)
        {

            return View(db.BeceriOZs.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult BeceriGuncelle(int id, BeceriOZ form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Beceri");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Odul()
        {
            var deger = db.OdullOZs.ToList();
            return View(deger);
        }
        public ActionResult OdulSil(int id)
        {
            var deger = db.OdullOZs.Find(id);
            db.OdullOZs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Odul");
        }

        [HttpGet]
        public ActionResult OdulGuncelle(int id)
        {

            return View(db.OdullOZs.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult OdulGuncelle(int id, OdullOZ form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Odul");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Galeri()
        {
            var deger = db.Galeris.ToList();
            return View(deger);
        }
        public ActionResult GaleriSil(int id)
        {
            var deger = db.Galeris.Find(id);
            db.Galeris.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Galeri");
        }

        [HttpGet]
        public ActionResult GaleriGuncelle(int id)
        {

            return View(db.Galeris.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult GaleriGuncelle(int id, Galeri form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Galeri");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SosyalHesap()
        {
            var deger = db.SosyalHesaps.ToList();
          
            return View(deger);
        }
        public ActionResult SosSil(int id)
        {
            var deger = db.SosyalHesaps.Find(id);
            db.SosyalHesaps.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("SosyalHesap");
        }
        [HttpGet]
        public ActionResult SosGuncelle(int id)
        {

            return View(db.SosyalHesaps.Where(m => m.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult SosGuncelle(int id, SosyalHesap form)
        {
            try
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("SosyalHesap");
            }
            catch
            {
                return View();
            }
        }

    }
}