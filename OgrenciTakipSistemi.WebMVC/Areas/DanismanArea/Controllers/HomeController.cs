using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OgrenciTakipSistemi.WebMVC.Areas.DanismanArea.Controllers
{
	[Area("DanismanArea")]
	[Authorize(Roles = "Danisman")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
