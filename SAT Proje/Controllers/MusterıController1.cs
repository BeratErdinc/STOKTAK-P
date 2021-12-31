using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SAT_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Controllers
{
    public class MusterıController1 : Controller
    {
        Context c = new Context();

        
        public IActionResult Index()
        {
            var degerler = c.Musterı.Include(x => x.urun).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Uruns.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.UrunAdı,
                                                 Value = x.UrunId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;

           
            
            return View();
        }

        public IActionResult YeniPersonel(Musterı mus)
        {
           
            var per = c.Uruns.Where(x => x.UrunId == mus.urun.UrunId).FirstOrDefault();
            mus.urun = per;
            c.Musterı.Add(mus);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            var dep = c.Musterı.Find(id);
            c.Musterı.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Düzenle(int id)
        {
            var per = c.Musterı.Where(x => x.MusterıId == id).FirstOrDefault();
            List<SelectListItem> degerler = (from x in c.Uruns.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.UrunAdı,
                                                 Value = x.UrunId.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler;

            return View(per);
        }

        [HttpPost]
        public IActionResult Düzenle(Musterı p)
        {

            var per = c.Musterı.Where(x => x.MusterıId == p.MusterıId).FirstOrDefault();
            per.MusterıAdıSoyadı = p.MusterıAdıSoyadı;
            per.MusterıSehır = p.MusterıSehır;
            per.SıparıDurum = p.SıparıDurum;
            per.Musterıtel = p.Musterıtel;
            per.MusterıAcıkAdres = p.MusterıAcıkAdres;

            var urun = c.Uruns.Where(x => x.UrunId == p.urun.UrunId).FirstOrDefault();
            per.urun = urun;

            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
