using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace Asp_Net_Opdracht1.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welkom(string naam, int leeftijd = 1)
        {
            ViewData["Bericht"] = "Hallo " + naam;
            ViewData["Leeftijd"] = leeftijd;

            return View();
        }
    }
}
