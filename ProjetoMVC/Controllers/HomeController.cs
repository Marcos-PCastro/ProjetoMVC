using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;
using System.Diagnostics;

namespace ProjetoMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            TempData["Nome"] = "Marcos";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}