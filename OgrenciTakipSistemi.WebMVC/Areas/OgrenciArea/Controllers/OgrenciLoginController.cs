using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Areas.OgrenciArea.Controllers
{
    public class OgrenciLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
