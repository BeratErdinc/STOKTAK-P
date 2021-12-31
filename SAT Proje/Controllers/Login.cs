using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SAT_Proje.Models;
using Microsoft.AspNetCore.Http;

namespace SAT_Proje.Controllers
{
    public class Login : Controller
    {
        Context x = new Context();
        public IActionResult GırısYap(string Kullanıcı,string Şifre)
        {
            var user = x.Admin.FirstOrDefault(w => w.Kullanıcı.Equals(Kullanıcı) && w.Şifre.Equals(Şifre));
            if (user !=null)
            {
                HttpContext.Session.SetInt32("id", user.AdminID);
                return Redirect("/UrunController1/Index");

            }
            return View();
        }
    }
}
