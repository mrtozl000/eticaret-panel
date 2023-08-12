using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace odev.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index(int sayfa=1)
        {
            var degerler = c.Kategorilers.ToList().ToPagedList(sayfa, 4);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategoriler k)
        {
            c.Kategorilers.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Kategorilers.Find(id);
            c.Kategorilers.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public  ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategorilers.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult KategoriGuncelle(Kategoriler k)
        {
            var ktgr = c.Kategorilers.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}