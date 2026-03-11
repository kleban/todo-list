using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoApp.Domain;
using ToDoApp.UI.Models;

namespace ToDoApp.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ToDoContext context;

        public HomeController(ToDoContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
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
