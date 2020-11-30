using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandevuSistemi.Models;
namespace RandevuSistemi.Controllers
{
    public class RandevuController : Controller
    {
        Context c = new Context();
        // GET: Randevu
        //Onay Bekleyen Randevuların Beklediği Yer
        public ActionResult Index()
        {
            var deger = c.Randevus.Where(x => x.Onay == false).ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult RandevuAl()
        {
            return View();
        }
        //Randevu Alınacak Yer.
        [HttpPost]
        public ActionResult RandevuAl(Randevu p)
        {
            c.Randevus.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //ID ye Göre Randevu Bulduruyoruz
        public ActionResult RandevuGetir(int id)
        {
            var rd = c.Randevus.Find(id);
            return View("RandevuGetir", rd);
        }
        //Burada Getirdiğimiz Randevuyu Güncelliyoruz
        public ActionResult RandevuGüncelle(Randevu r)
        {
            var ran = c.Randevus.Find(r.RandevuId);
            ran.Tarih = r.Tarih;
            ran.Onay = true;
            c.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}