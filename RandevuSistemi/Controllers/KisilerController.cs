using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandevuSistemi.Models;
using System.Text.RegularExpressions;
namespace RandevuSistemi.Controllers
{
    public class KisilerController : Controller
    {
        Context c = new Context();
        // GET: Kisiler
        //Kişilerin Listesi
        public ActionResult Index()
        {
            var deger = c.Kisilers.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult KisiEkle()
        {
            return View();
        }
        //Kişi Ekleme Sayfası.
        [HttpPost]
        public ActionResult KisiEkle(Kisiler p)
        {
            //if (!ModelState.IsValid)
            //{
              
            //    return View();

            //}
            c.Kisilers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}