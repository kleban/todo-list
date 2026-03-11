using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain;

namespace ToDoApp.UI.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext context;

        public ToDoController(ToDoContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var tasks = context.ToDos.ToList();
            return View(tasks);
        }
    }
}
