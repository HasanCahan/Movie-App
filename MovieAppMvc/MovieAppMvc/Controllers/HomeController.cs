using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MovieAppMvc.Models;
using MovieAppMvc.Veriler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PagedList;

namespace MovieAppMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? id)//FİLMLERİ KATEGORİYE (İd) GÖRE GETİRME
        {
            var films = FilmVeri.Films;
            if (id != null)
            {
                films = films.Where(i => i.KategoriId == id).ToList();
            }
            return View(films);
        }

        public IActionResult Detaylar(int id)
        {
            return View(FilmVeri.GetById(id));
        }

        public IActionResult İletişim()
        {
            return View();
        }

        public IActionResult Olustur()
        {
            ViewBag.Kategoris = new SelectList(KategoriVeri.Kategoris, "Id", "KategoriTürü");
            return View();
        }

        [HttpPost]
        public IActionResult Olustur(Film f)

        {
            if (ModelState.IsValid)
            {
                FilmVeri.FilmEkle(f);
                return RedirectToAction("Index");

            }
            return View(f);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
