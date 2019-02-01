using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab40111_MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        //This Is The Index Page. Use This Block Of Code To Create New Pages.
        public IActionResult Index()
        {
            return View();
        }

    }
}

