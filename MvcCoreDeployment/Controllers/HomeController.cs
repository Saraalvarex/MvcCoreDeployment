using Microsoft.AspNetCore.Mvc;
using MvcCoreDeployment.Models;
using System.Diagnostics;

namespace MvcCoreDeployment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.SALUDO = "Bien ve ni dos";
            Random rdm = new Random();
            List<int> numeros = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                int num = rdm.Next(1, 100);
                numeros.Add(num);
            }
            return View(numeros);
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