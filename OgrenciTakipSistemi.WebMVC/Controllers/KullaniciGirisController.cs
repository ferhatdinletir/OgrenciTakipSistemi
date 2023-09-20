using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Controllers
{
    public class KullaniciGirisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
