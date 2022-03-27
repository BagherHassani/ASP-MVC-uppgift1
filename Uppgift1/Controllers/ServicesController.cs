using Microsoft.AspNetCore.Mvc;

namespace Uppgift1.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
