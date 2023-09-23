using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class DanismanController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
