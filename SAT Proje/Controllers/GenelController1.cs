using Microsoft.AspNetCore.Mvc;
using SAT_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAT_Proje.Controllers
{
    public class GenelController1 : Controller
    {
        public IActionResult Index()
        {
            return View(new Durum().GetModelState());
            
        }
    }
}
 