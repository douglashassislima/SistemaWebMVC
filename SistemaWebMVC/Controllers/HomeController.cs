using Microsoft.AspNetCore.Mvc;
using SistemaWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebMVC.Models.ViewModels;

namespace SistemaWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "AvaEstags - Cadastro de novos Desenvolvedores Estagiários";
            ViewData["Developer"] = "Douglas Henrique de Assis Lima";
 
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "E-mail";
            ViewData["E-mail"] = "douglashenriquedeassis@gmail.com";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new SistemaWebMVC.Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
