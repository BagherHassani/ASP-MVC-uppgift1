using Microsoft.AspNetCore.Mvc;

namespace Uppgift1.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
