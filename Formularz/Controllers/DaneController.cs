using Formularz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Formularz.Controllers
{
   public class DaneController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Miasta = new[] { "Warszawa", "Kraków", "Gdańsk", "Wrocław", "Poznań" };
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            ViewBag.Miasta = new[] { "Warszawa", "Kraków", "Gdańsk", "Wrocław", "Poznań" };

            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else
            {
                return View(dane);
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}