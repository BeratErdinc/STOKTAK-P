using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAT_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Controllers
{
    public class UrunController1 : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
          
        }
        [HttpGet] // SAYFA YUKLENIRKEN
        public IActionResult YeniUrun()
        {
            return View();
        }

        [HttpPost] // Sayfamda post işlemi gerçekleştiriken çalışır
        public IActionResult YeniUrun(Urun b)
        {
            c.Uruns.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
     
        public IActionResult Sil(int id)
        {
            var dep = c.Uruns.Find(id);
            c.Uruns.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Getir(int id)
        {
            var dep = c.Uruns.Find(id);
            return View("Getir", dep);
        }

        public IActionResult Güncelle(Urun b)
        {
            var dep = c.Uruns.Find(b.UrunId);
            dep.UrunAdı = b.UrunAdı;
            dep.UrunAdet = b.UrunAdet;
            dep.UrunAcıklama = b.UrunAcıklama;
            dep.UrunBarkod = b.UrunBarkod;
            dep.UrunFıyat = b.UrunFıyat;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Detay(int id)
        {
            var degerler = c.Musterı.Where(x => x.UrunId == id).ToList();
            var ürünad = c.Uruns.Where(x => x.UrunId == id).Select(y => y.UrunAdı).FirstOrDefault();
            ViewBag.urn = ürünad;
            return View(degerler);

        }
    }
}
