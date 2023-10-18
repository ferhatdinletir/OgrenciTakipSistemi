using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Areas.OgrenciArea.Controllers
{
	[Area("OgrenciArea")]
	[Authorize(Roles = "Ogrenci")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
