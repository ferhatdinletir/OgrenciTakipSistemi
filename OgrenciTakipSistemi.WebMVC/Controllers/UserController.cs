using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
