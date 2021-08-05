using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppMvc.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Liste()
        {
            return View();
        }
        public IActionResult Detay()
        {
            return View();
        }
    }
}
