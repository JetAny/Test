using Microsoft.AspNetCore.Mvc;

namespace MyIdentity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
