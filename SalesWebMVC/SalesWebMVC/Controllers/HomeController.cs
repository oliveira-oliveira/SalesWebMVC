using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicação de Vendas Web.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Página de Contato.";
            ViewData["Mail"] = "diego.oliveira@mail.com.";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "Página de privacidade.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
