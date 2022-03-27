using Microsoft.AspNetCore.Mvc;

namespace Uppgift1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
