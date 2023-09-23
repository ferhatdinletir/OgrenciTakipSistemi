using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
