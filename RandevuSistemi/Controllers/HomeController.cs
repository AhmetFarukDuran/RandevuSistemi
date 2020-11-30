using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandevuSistemi.Models;
namespace RandevuSistemi.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        //Onaylanan Randevuları Görüntülediğimiz Yer.
        public ActionResult Index()
        {
            var deger = c.Randevus.Where(x => x.Onay == true).ToList();
            return View(deger);
        }
       
    }
}