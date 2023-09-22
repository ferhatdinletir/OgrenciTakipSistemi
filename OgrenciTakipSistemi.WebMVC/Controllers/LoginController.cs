using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
