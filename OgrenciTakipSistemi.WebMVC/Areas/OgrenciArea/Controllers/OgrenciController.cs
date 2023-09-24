using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Areas.OgrenciArea.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
